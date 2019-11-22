Shader "Custom/WaveShader"
{
   
    Properties
    {

    }
    
    SubShader
    {
        Tags { "RenderType"="Opaque" }  

        Pass 
        {
            CGPROGRAM 
            #pragma vertex vertexShader 
            #pragma fragment fragmentShader 
            
            #include "UnityCG.cginc" 
            
            struct vertexInput
            {
                float4 position : POSITION; 
            };

            
            struct vertexOutput
            {
                float4 position : SV_POSITION;
            };

            vertexOutput vertexShader (vertexInput vInput)
            {
                vertexOutput vOutput;

                

                vOutput.position = mul(unity_ObjectToWorld, vInput.position); 
                vOutput.position.y += sin(_Time[1] + vOutput.position.x ) * .3;
               
                vOutput.position = mul(UNITY_MATRIX_V, vOutput.position);
                
                vOutput.position = mul(UNITY_MATRIX_P, vOutput.position);

                

                return vOutput;
            }
            
            fixed4 fragmentShader (vertexOutput vOutput) : SV_Target
            {
                
                fixed4 col = fixed4(1,.987,.86,1); 
                return col;
            }

            ENDCG
        }
    }
}
