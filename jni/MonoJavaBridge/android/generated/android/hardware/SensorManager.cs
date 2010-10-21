namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SensorManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SensorManager()
		{
			InitJNI();
		}
		protected SensorManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOrientation6431;
		public static float[] getOrientation(float[] arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._getOrientation6431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _getInclination6432;
		public static float getInclination(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._getInclination6432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Sensors
		{
			get
			{
				return getSensors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSensors6433;
		public virtual int getSensors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.SensorManager._getSensors6433);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._getSensors6433);
		}
		internal static global::MonoJavaBridge.MethodId _getSensorList6434;
		public virtual global::java.util.List getSensorList(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.SensorManager._getSensorList6434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._getSensorList6434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultSensor6435;
		public virtual global::android.hardware.Sensor getDefaultSensor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.SensorManager._getDefaultSensor6435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.hardware.Sensor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._getDefaultSensor6435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.hardware.Sensor;
		}
		internal static global::MonoJavaBridge.MethodId _registerListener6436;
		public virtual bool registerListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager._registerListener6436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._registerListener6436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerListener6437;
		public virtual bool registerListener(android.hardware.SensorListener arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager._registerListener6437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._registerListener6437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerListener6438;
		public virtual bool registerListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1, int arg2, android.os.Handler arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager._registerListener6438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._registerListener6438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _registerListener6439;
		public virtual bool registerListener(android.hardware.SensorListener arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager._registerListener6439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._registerListener6439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterListener6440;
		public virtual void unregisterListener(android.hardware.SensorListener arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorManager._unregisterListener6440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._unregisterListener6440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterListener6441;
		public virtual void unregisterListener(android.hardware.SensorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorManager._unregisterListener6441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._unregisterListener6441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterListener6442;
		public virtual void unregisterListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorManager._unregisterListener6442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._unregisterListener6442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterListener6443;
		public virtual void unregisterListener(android.hardware.SensorEventListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.SensorManager._unregisterListener6443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._unregisterListener6443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRotationMatrix6444;
		public static bool getRotationMatrix(float[] arg0, float[] arg1, float[] arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._getRotationMatrix6444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _remapCoordinateSystem6445;
		public static bool remapCoordinateSystem(float[] arg0, int arg1, int arg2, float[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._remapCoordinateSystem6445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorManager"));
			global::android.hardware.SensorManager._getOrientation6431 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getOrientation", "([F[F)[F");
			global::android.hardware.SensorManager._getInclination6432 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getInclination", "([F)F");
			global::android.hardware.SensorManager._getSensors6433 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getSensors", "()I");
			global::android.hardware.SensorManager._getSensorList6434 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getSensorList", "(I)Ljava/util/List;");
			global::android.hardware.SensorManager._getDefaultSensor6435 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getDefaultSensor", "(I)Landroid/hardware/Sensor;");
			global::android.hardware.SensorManager._registerListener6436 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;I)Z");
			global::android.hardware.SensorManager._registerListener6437 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorListener;II)Z");
			global::android.hardware.SensorManager._registerListener6438 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;ILandroid/os/Handler;)Z");
			global::android.hardware.SensorManager._registerListener6439 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorListener;I)Z");
			global::android.hardware.SensorManager._unregisterListener6440 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorListener;I)V");
			global::android.hardware.SensorManager._unregisterListener6441 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorListener;)V");
			global::android.hardware.SensorManager._unregisterListener6442 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;)V");
			global::android.hardware.SensorManager._unregisterListener6443 = @__env.GetMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorEventListener;)V");
			global::android.hardware.SensorManager._getRotationMatrix6444 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getRotationMatrix", "([F[F[F[F)Z");
			global::android.hardware.SensorManager._remapCoordinateSystem6445 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "remapCoordinateSystem", "([FII[F)Z");
		}
	}
}
