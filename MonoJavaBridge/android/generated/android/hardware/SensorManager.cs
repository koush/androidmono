namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SensorManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SensorManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static float[] getOrientation(float[] arg0, float[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.SensorManager._m0.native == global::System.IntPtr.Zero)
				global::android.hardware.SensorManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getOrientation", "([F[F)[F");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static float getInclination(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.SensorManager._m1.native == global::System.IntPtr.Zero)
				global::android.hardware.SensorManager._m1 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getInclination", "([F)F");
			return @__env.CallStaticFloatMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Sensors
		{
			get
			{
				return getSensors();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getSensors()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.SensorManager.staticClass, "getSensors", "()I", ref global::android.hardware.SensorManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.util.List getSensorList(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.SensorManager.staticClass, "getSensorList", "(I)Ljava/util/List;", ref global::android.hardware.SensorManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.hardware.Sensor getDefaultSensor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.SensorManager.staticClass, "getDefaultSensor", "(I)Landroid/hardware/Sensor;", ref global::android.hardware.SensorManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.hardware.Sensor;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool registerListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;I)Z", ref global::android.hardware.SensorManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool registerListener(android.hardware.SensorListener arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorListener;II)Z", ref global::android.hardware.SensorManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool registerListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1, int arg2, android.os.Handler arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;ILandroid/os/Handler;)Z", ref global::android.hardware.SensorManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool registerListener(android.hardware.SensorListener arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.SensorManager.staticClass, "registerListener", "(Landroid/hardware/SensorListener;I)Z", ref global::android.hardware.SensorManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void unregisterListener(android.hardware.SensorListener arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorListener;I)V", ref global::android.hardware.SensorManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void unregisterListener(android.hardware.SensorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorListener;)V", ref global::android.hardware.SensorManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void unregisterListener(android.hardware.SensorEventListener arg0, android.hardware.Sensor arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;)V", ref global::android.hardware.SensorManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void unregisterListener(android.hardware.SensorEventListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.SensorManager.staticClass, "unregisterListener", "(Landroid/hardware/SensorEventListener;)V", ref global::android.hardware.SensorManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool getRotationMatrix(float[] arg0, float[] arg1, float[] arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.SensorManager._m13.native == global::System.IntPtr.Zero)
				global::android.hardware.SensorManager._m13 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "getRotationMatrix", "([F[F[F[F)Z");
			return @__env.CallStaticBooleanMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static bool remapCoordinateSystem(float[] arg0, int arg1, int arg2, float[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.SensorManager._m14.native == global::System.IntPtr.Zero)
				global::android.hardware.SensorManager._m14 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.SensorManager.staticClass, "remapCoordinateSystem", "([FII[F)Z");
			return @__env.CallStaticBooleanMethod(android.hardware.SensorManager.staticClass, global::android.hardware.SensorManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		static SensorManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.SensorManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/SensorManager"));
		}
	}
}
