using System;
namespace Traffic_Simulator
{
	public interface LightProperties {
        void SetColor(System.Drawing.Color color);
        System.Drawing.Color GetColor();
		void SetState(bool state);
		bool GetState();

	}

}
