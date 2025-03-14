using UnityEngine;

public interface IVehicleBase
{
	void Enter();
	void Exit();

	/// <summary>
	/// -1 to 1 float for min max steering angle. Scale at your end
	/// </summary>
	/// <param name="amount"></param>
	void Steer(float amount);

	/// <summary>
	/// 0 to 1 float for min max acceleration. Scale at your end
	/// </summary>
	/// <param name="amount"></param>
	void Accelerate(float amount);

	/// <summary>
	/// You must make a child GO at the point of exit on your vehicle and return it here
	/// </summary>
	/// <returns></returns>
	Transform GetVehicleExitPoint();
}