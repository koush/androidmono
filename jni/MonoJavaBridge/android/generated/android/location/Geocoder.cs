namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Geocoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Geocoder()
		{
			InitJNI();
		}
		internal Geocoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFromLocation6838;
		public global::java.util.List getFromLocation(double arg0, double arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Geocoder._getFromLocation6838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Geocoder.staticClass, global::android.location.Geocoder._getFromLocation6838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getFromLocationName6839;
		public global::java.util.List getFromLocationName(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Geocoder._getFromLocationName6839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Geocoder.staticClass, global::android.location.Geocoder._getFromLocationName6839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getFromLocationName6840;
		public global::java.util.List getFromLocationName(java.lang.String arg0, int arg1, double arg2, double arg3, double arg4, double arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Geocoder._getFromLocationName6840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Geocoder.staticClass, global::android.location.Geocoder._getFromLocationName6840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _Geocoder6841;
		public Geocoder(android.content.Context arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Geocoder.staticClass, global::android.location.Geocoder._Geocoder6841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Geocoder6842;
		public Geocoder(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Geocoder.staticClass, global::android.location.Geocoder._Geocoder6842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Geocoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Geocoder"));
			global::android.location.Geocoder._getFromLocation6838 = @__env.GetMethodIDNoThrow(global::android.location.Geocoder.staticClass, "getFromLocation", "(DDI)Ljava/util/List;");
			global::android.location.Geocoder._getFromLocationName6839 = @__env.GetMethodIDNoThrow(global::android.location.Geocoder.staticClass, "getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;");
			global::android.location.Geocoder._getFromLocationName6840 = @__env.GetMethodIDNoThrow(global::android.location.Geocoder.staticClass, "getFromLocationName", "(Ljava/lang/String;IDDDD)Ljava/util/List;");
			global::android.location.Geocoder._Geocoder6841 = @__env.GetMethodIDNoThrow(global::android.location.Geocoder.staticClass, "<init>", "(Landroid/content/Context;Ljava/util/Locale;)V");
			global::android.location.Geocoder._Geocoder6842 = @__env.GetMethodIDNoThrow(global::android.location.Geocoder.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
