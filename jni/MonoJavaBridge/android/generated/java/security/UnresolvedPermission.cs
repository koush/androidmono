namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class UnresolvedPermission : java.security.Permission, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnresolvedPermission()
		{
			InitJNI();
		}
		internal UnresolvedPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals17699;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission._equals17699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._equals17699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString17700;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._toString17700)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._toString17700)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode17701;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.UnresolvedPermission._hashCode17701);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._hashCode17701);
		}
		internal static global::MonoJavaBridge.MethodId _implies17702;
		public sealed override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission._implies17702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._implies17702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Actions
		{
			get
			{
				return getActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActions17703;
		public sealed override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getActions17703)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getActions17703)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection17704;
		public sealed override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._newPermissionCollection17704)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._newPermissionCollection17704)) as java.security.PermissionCollection;
		}
		public new global::java.lang.String UnresolvedType
		{
			get
			{
				return getUnresolvedType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedType17705;
		public global::java.lang.String getUnresolvedType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedType17705)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedType17705)) as java.lang.String;
		}
		public new global::java.lang.String UnresolvedName
		{
			get
			{
				return getUnresolvedName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedName17706;
		public global::java.lang.String getUnresolvedName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedName17706)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedName17706)) as java.lang.String;
		}
		public new global::java.lang.String UnresolvedActions
		{
			get
			{
				return getUnresolvedActions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedActions17707;
		public global::java.lang.String getUnresolvedActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedActions17707)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedActions17707)) as java.lang.String;
		}
		public new global::java.security.cert.Certificate[] UnresolvedCerts
		{
			get
			{
				return getUnresolvedCerts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUnresolvedCerts17708;
		public global::java.security.cert.Certificate[] getUnresolvedCerts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission._getUnresolvedCerts17708)) as java.security.cert.Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._getUnresolvedCerts17708)) as java.security.cert.Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _UnresolvedPermission17709;
		public UnresolvedPermission(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.security.cert.Certificate[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.UnresolvedPermission.staticClass, global::java.security.UnresolvedPermission._UnresolvedPermission17709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.UnresolvedPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/UnresolvedPermission"));
			global::java.security.UnresolvedPermission._equals17699 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.UnresolvedPermission._toString17700 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._hashCode17701 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "hashCode", "()I");
			global::java.security.UnresolvedPermission._implies17702 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.UnresolvedPermission._getActions17703 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._newPermissionCollection17704 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.security.UnresolvedPermission._getUnresolvedType17705 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedType", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._getUnresolvedName17706 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedName", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._getUnresolvedActions17707 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedActions", "()Ljava/lang/String;");
			global::java.security.UnresolvedPermission._getUnresolvedCerts17708 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "getUnresolvedCerts", "()[Ljava/security/cert/Certificate;");
			global::java.security.UnresolvedPermission._UnresolvedPermission17709 = @__env.GetMethodIDNoThrow(global::java.security.UnresolvedPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/security/cert/Certificate;)V");
		}
	}
}
