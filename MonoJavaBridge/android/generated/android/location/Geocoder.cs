namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Geocoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Geocoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.util.List getFromLocation(double arg0, double arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.location.Geocoder.staticClass, "getFromLocation", "(DDI)Ljava/util/List;", ref global::android.location.Geocoder._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.util.List getFromLocationName(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.location.Geocoder.staticClass, "getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;", ref global::android.location.Geocoder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.util.List getFromLocationName(java.lang.String arg0, int arg1, double arg2, double arg3, double arg4, double arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.location.Geocoder.staticClass, "getFromLocationName", "(Ljava/lang/String;IDDDD)Ljava/util/List;", ref global::android.location.Geocoder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Geocoder(android.content.Context arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Geocoder._m3.native == global::System.IntPtr.Zero)
				global::android.location.Geocoder._m3 = @__env.GetMethodIDNoThrow(global::android.location.Geocoder.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Geocoder.staticClass, global::android.location.Geocoder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public Geocoder(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Geocoder._m4.native == global::System.IntPtr.Zero)
				global::android.location.Geocoder._m4 = @__env.GetMethodIDNoThrow(global::android.location.Geocoder.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Geocoder.staticClass, global::android.location.Geocoder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Geocoder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Geocoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Geocoder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
