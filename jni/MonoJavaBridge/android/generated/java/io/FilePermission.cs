namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class FilePermission : java.security.Permission, Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilePermission()
		{
			InitJNI();
		}
		internal FilePermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals13450;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilePermission._equals13450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilePermission.staticClass, global::java.io.FilePermission._equals13450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13451;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.FilePermission._hashCode13451);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.FilePermission.staticClass, global::java.io.FilePermission._hashCode13451);
		}
		internal static global::MonoJavaBridge.MethodId _implies13452;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.FilePermission._implies13452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.FilePermission.staticClass, global::java.io.FilePermission._implies13452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions13453;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FilePermission._getActions13453)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FilePermission.staticClass, global::java.io.FilePermission._getActions13453)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection13454;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.FilePermission._newPermissionCollection13454)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.FilePermission.staticClass, global::java.io.FilePermission._newPermissionCollection13454)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _FilePermission13455;
		public FilePermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilePermission.staticClass, global::java.io.FilePermission._FilePermission13455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilePermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilePermission"));
			global::java.io.FilePermission._equals13450 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.io.FilePermission._hashCode13451 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "hashCode", "()I");
			global::java.io.FilePermission._implies13452 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.io.FilePermission._getActions13453 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.io.FilePermission._newPermissionCollection13454 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.io.FilePermission._FilePermission13455 = @__env.GetMethodIDNoThrow(global::java.io.FilePermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
