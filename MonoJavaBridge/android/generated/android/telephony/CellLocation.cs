namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.telephony.CellLocation_))]
	public abstract partial class CellLocation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void requestLocationUpdate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.CellLocation._m0.native == global::System.IntPtr.Zero)
				global::android.telephony.CellLocation._m0 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.CellLocation.staticClass, "requestLocationUpdate", "()V");
			@__env.CallStaticVoidMethod(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.telephony.CellLocation getEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.CellLocation._m1.native == global::System.IntPtr.Zero)
				global::android.telephony.CellLocation._m1 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.CellLocation.staticClass, "getEmpty", "()Landroid/telephony/CellLocation;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._m1)) as android.telephony.CellLocation;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public CellLocation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.CellLocation._m2.native == global::System.IntPtr.Zero)
				global::android.telephony.CellLocation._m2 = @__env.GetMethodIDNoThrow(global::android.telephony.CellLocation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._m2);
			Init(@__env, handle);
		}
		static CellLocation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.CellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/CellLocation"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.telephony.CellLocation))]
	internal sealed partial class CellLocation_ : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CellLocation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static CellLocation_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.CellLocation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/CellLocation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
