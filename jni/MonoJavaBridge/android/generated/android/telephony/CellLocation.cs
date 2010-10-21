namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.telephony.CellLocation_))]
	public abstract partial class CellLocation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CellLocation()
		{
			InitJNI();
		}
		protected CellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _requestLocationUpdate11716;
		public static void requestLocationUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._requestLocationUpdate11716);
		}
		internal static global::MonoJavaBridge.MethodId _getEmpty11717;
		public static global::android.telephony.CellLocation getEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._getEmpty11717)) as android.telephony.CellLocation;
		}
		internal static global::MonoJavaBridge.MethodId _CellLocation11718;
		public CellLocation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._CellLocation11718);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.CellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/CellLocation"));
			global::android.telephony.CellLocation._requestLocationUpdate11716 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.CellLocation.staticClass, "requestLocationUpdate", "()V");
			global::android.telephony.CellLocation._getEmpty11717 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.CellLocation.staticClass, "getEmpty", "()Landroid/telephony/CellLocation;");
			global::android.telephony.CellLocation._CellLocation11718 = @__env.GetMethodIDNoThrow(global::android.telephony.CellLocation.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.telephony.CellLocation))]
	public sealed partial class CellLocation_ : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CellLocation_()
		{
			InitJNI();
		}
		internal CellLocation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.CellLocation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/CellLocation"));
		}
	}
}
