namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SensorManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SensorManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.hardware.SensorManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.hardware.SensorManager(@__env); 
			} 
		} 
		protected SensorManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation3730; 
		public static float[] getOrientation(float[] arg0, float[] arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.hardware.SensorManager.staticClass, _getOrientation3730, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInclination3731; 
		public static float getInclination(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.hardware.SensorManager.staticClass, _getInclination3731, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSensors3732; 
		public virtual int getSensors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				return @__env.CallIntMethod(this, _getSensors3732); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.hardware.SensorManager.staticClass, _getSensors3732); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSensorList3733; 
		public virtual java.util.List getSensorList(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSensorList3733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.SensorManager.staticClass, _getSensorList3733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultSensor3734; 
		public virtual android.hardware.Sensor getDefaultSensor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Sensor>(@__env, @__env.CallObjectMethodPtr(this, _getDefaultSensor3734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Sensor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.SensorManager.staticClass, _getDefaultSensor3734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerListener3735; 
		public virtual bool registerListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				return @__env.CallBooleanMethod(this, _registerListener3735, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.hardware.SensorManager.staticClass, _registerListener3735, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerListener3736; 
		public virtual bool registerListener(android.hardware.SensorListener arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				return @__env.CallBooleanMethod(this, _registerListener3736, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.hardware.SensorManager.staticClass, _registerListener3736, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerListener3737; 
		public virtual bool registerListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1, int arg2, android.os.Handler arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				return @__env.CallBooleanMethod(this, _registerListener3737, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.hardware.SensorManager.staticClass, _registerListener3737, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerListener3738; 
		public virtual bool registerListener(android.hardware.SensorListener arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				return @__env.CallBooleanMethod(this, _registerListener3738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.hardware.SensorManager.staticClass, _registerListener3738, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterListener3739; 
		public virtual void unregisterListener(android.hardware.SensorListener arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				@__env.CallVoidMethod(this, _unregisterListener3739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.SensorManager.staticClass, _unregisterListener3739, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterListener3740; 
		public virtual void unregisterListener(android.hardware.SensorListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				@__env.CallVoidMethod(this, _unregisterListener3740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.SensorManager.staticClass, _unregisterListener3740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterListener3741; 
		public virtual void unregisterListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				@__env.CallVoidMethod(this, _unregisterListener3741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.SensorManager.staticClass, _unregisterListener3741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterListener3742; 
		public virtual void unregisterListener(android.hardware.SensorEventListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.SensorManager)) 
				@__env.CallVoidMethod(this, _unregisterListener3742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.SensorManager.staticClass, _unregisterListener3742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRotationMatrix3743; 
		public static bool getRotationMatrix(float[] arg0, float[] arg1, float[] arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.hardware.SensorManager.staticClass, _getRotationMatrix3743, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remapCoordinateSystem3744; 
		public static bool remapCoordinateSystem(float[] arg0, int arg1, int arg2, float[] arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.hardware.SensorManager.staticClass, _remapCoordinateSystem3744, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		public static int SENSOR_ORIENTATION
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SENSOR_ACCELEROMETER
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int SENSOR_TEMPERATURE
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int SENSOR_MAGNETIC_FIELD
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int SENSOR_LIGHT
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int SENSOR_PROXIMITY
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int SENSOR_TRICORDER
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int SENSOR_ORIENTATION_RAW
		{ 
			get 
			{ 
				return 128; 
			} 
		} 
		public static int SENSOR_ALL
		{ 
			get 
			{ 
				return 127; 
			} 
		} 
		public static int SENSOR_MIN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SENSOR_MAX
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int DATA_X
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int DATA_Y
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DATA_Z
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int RAW_DATA_INDEX
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int RAW_DATA_X
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int RAW_DATA_Y
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int RAW_DATA_Z
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static float STANDARD_GRAVITY
		{ 
			get 
			{ 
				return 9.80665f; 
			} 
		} 
		public static float GRAVITY_SUN
		{ 
			get 
			{ 
				return 275.0f; 
			} 
		} 
		public static float GRAVITY_MERCURY
		{ 
			get 
			{ 
				return 3.7f; 
			} 
		} 
		public static float GRAVITY_VENUS
		{ 
			get 
			{ 
				return 8.87f; 
			} 
		} 
		public static float GRAVITY_EARTH
		{ 
			get 
			{ 
				return 9.80665f; 
			} 
		} 
		public static float GRAVITY_MOON
		{ 
			get 
			{ 
				return 1.6f; 
			} 
		} 
		public static float GRAVITY_MARS
		{ 
			get 
			{ 
				return 3.71f; 
			} 
		} 
		public static float GRAVITY_JUPITER
		{ 
			get 
			{ 
				return 23.12f; 
			} 
		} 
		public static float GRAVITY_SATURN
		{ 
			get 
			{ 
				return 8.96f; 
			} 
		} 
		public static float GRAVITY_URANUS
		{ 
			get 
			{ 
				return 8.69f; 
			} 
		} 
		public static float GRAVITY_NEPTUNE
		{ 
			get 
			{ 
				return 11.0f; 
			} 
		} 
		public static float GRAVITY_PLUTO
		{ 
			get 
			{ 
				return 0.6f; 
			} 
		} 
		public static float GRAVITY_DEATH_STAR_I
		{ 
			get 
			{ 
				return 3.5303614E-7f; 
			} 
		} 
		public static float GRAVITY_THE_ISLAND
		{ 
			get 
			{ 
				return 4.815162f; 
			} 
		} 
		public static float MAGNETIC_FIELD_EARTH_MAX
		{ 
			get 
			{ 
				return 60.0f; 
			} 
		} 
		public static float MAGNETIC_FIELD_EARTH_MIN
		{ 
			get 
			{ 
				return 30.0f; 
			} 
		} 
		public static float LIGHT_SUNLIGHT_MAX
		{ 
			get 
			{ 
				return 120000.0f; 
			} 
		} 
		public static float LIGHT_SUNLIGHT
		{ 
			get 
			{ 
				return 110000.0f; 
			} 
		} 
		public static float LIGHT_SHADE
		{ 
			get 
			{ 
				return 20000.0f; 
			} 
		} 
		public static float LIGHT_OVERCAST
		{ 
			get 
			{ 
				return 10000.0f; 
			} 
		} 
		public static float LIGHT_SUNRISE
		{ 
			get 
			{ 
				return 400.0f; 
			} 
		} 
		public static float LIGHT_CLOUDY
		{ 
			get 
			{ 
				return 100.0f; 
			} 
		} 
		public static float LIGHT_FULLMOON
		{ 
			get 
			{ 
				return 0.25f; 
			} 
		} 
		public static float LIGHT_NO_MOON
		{ 
			get 
			{ 
				return 0.0010f; 
			} 
		} 
		public static int SENSOR_DELAY_FASTEST
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int SENSOR_DELAY_GAME
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SENSOR_DELAY_UI
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int SENSOR_DELAY_NORMAL
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int SENSOR_STATUS_UNRELIABLE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int SENSOR_STATUS_ACCURACY_LOW
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SENSOR_STATUS_ACCURACY_MEDIUM
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int SENSOR_STATUS_ACCURACY_HIGH
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int AXIS_X
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int AXIS_Y
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int AXIS_Z
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int AXIS_MINUS_X
		{ 
			get 
			{ 
				return 129; 
			} 
		} 
		public static int AXIS_MINUS_Y
		{ 
			get 
			{ 
				return 130; 
			} 
		} 
		public static int AXIS_MINUS_Z
		{ 
			get 
			{ 
				return 131; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.hardware.SensorManager.staticClass = @__class; 
			global::android.hardware.SensorManager._getOrientation3730 = @__env.GetStaticMethodID(global::android.hardware.SensorManager.staticClass, "getOrientation", "([F[F)[F"); 
			global::android.hardware.SensorManager._getInclination3731 = @__env.GetStaticMethodID(global::android.hardware.SensorManager.staticClass, "getInclination", "([F)F"); 
			global::android.hardware.SensorManager._getSensors3732 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "getSensors", "()I"); 
			global::android.hardware.SensorManager._getSensorList3733 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "getSensorList", "(I)Ljava/util/List;"); 
			global::android.hardware.SensorManager._getDefaultSensor3734 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "getDefaultSensor", "(I)Landroid/hardware/Sensor;"); 
			global::android.hardware.SensorManager._registerListener3735 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;I)Z"); 
			global::android.hardware.SensorManager._registerListener3736 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorListener;II)Z"); 
			global::android.hardware.SensorManager._registerListener3737 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;ILandroid/os/Handler;)Z"); 
			global::android.hardware.SensorManager._registerListener3738 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorListener;I)Z"); 
			global::android.hardware.SensorManager._unregisterListener3739 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorListener;I)V"); 
			global::android.hardware.SensorManager._unregisterListener3740 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorListener;)V"); 
			global::android.hardware.SensorManager._unregisterListener3741 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;)V"); 
			global::android.hardware.SensorManager._unregisterListener3742 = @__env.GetMethodID(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorEventListener;)V"); 
			global::android.hardware.SensorManager._getRotationMatrix3743 = @__env.GetStaticMethodID(global::android.hardware.SensorManager.staticClass, "getRotationMatrix", "([F[F[F[F)Z"); 
			global::android.hardware.SensorManager._remapCoordinateSystem3744 = @__env.GetStaticMethodID(global::android.hardware.SensorManager.staticClass, "remapCoordinateSystem", "([FII[F)Z"); 
		} 
	} 
} 
