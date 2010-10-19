namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathPermission : android.os.PatternMatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PathPermission()
		{
			InitJNI();
		}
		protected PathPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2115;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PathPermission._writeToParcel2115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._writeToParcel2115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String ReadPermission
		{
			get
			{
				return getReadPermission();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReadPermission2116;
		public virtual global::java.lang.String getReadPermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission._getReadPermission2116)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._getReadPermission2116)) as java.lang.String;
		}
		public new global::java.lang.String WritePermission
		{
			get
			{
				return getWritePermission();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWritePermission2117;
		public virtual global::java.lang.String getWritePermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission._getWritePermission2117)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._getWritePermission2117)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PathPermission2118;
		public PathPermission(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._PathPermission2118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PathPermission2119;
		public PathPermission(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PathPermission.staticClass, global::android.content.pm.PathPermission._PathPermission2119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2120;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PathPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PathPermission"));
			global::android.content.pm.PathPermission._writeToParcel2115 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PathPermission._getReadPermission2116 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "getReadPermission", "()Ljava/lang/String;");
			global::android.content.pm.PathPermission._getWritePermission2117 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "getWritePermission", "()Ljava/lang/String;");
			global::android.content.pm.PathPermission._PathPermission2118 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::android.content.pm.PathPermission._PathPermission2119 = @__env.GetMethodIDNoThrow(global::android.content.pm.PathPermission.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
