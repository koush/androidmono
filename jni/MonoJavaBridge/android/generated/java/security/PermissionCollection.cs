namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.PermissionCollection_))]
	public abstract partial class PermissionCollection : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PermissionCollection()
		{
			InitJNI();
		}
		protected PermissionCollection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add17497;
		public abstract void add(java.security.Permission arg0);
		internal static global::MonoJavaBridge.MethodId _toString17498;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PermissionCollection._toString17498)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._toString17498)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _implies17499;
		public abstract bool implies(java.security.Permission arg0);
		internal static global::MonoJavaBridge.MethodId _setReadOnly17500;
		public virtual void setReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.PermissionCollection._setReadOnly17500);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._setReadOnly17500);
		}
		internal static global::MonoJavaBridge.MethodId _elements17501;
		public abstract global::java.util.Enumeration elements();
		internal static global::MonoJavaBridge.MethodId _isReadOnly17502;
		public virtual bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection._isReadOnly17502);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._isReadOnly17502);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionCollection17503;
		public PermissionCollection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._PermissionCollection17503);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
			global::java.security.PermissionCollection._add17497 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.PermissionCollection._toString17498 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.PermissionCollection._implies17499 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.PermissionCollection._setReadOnly17500 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "setReadOnly", "()V");
			global::java.security.PermissionCollection._elements17501 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.PermissionCollection._isReadOnly17502 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "isReadOnly", "()Z");
			global::java.security.PermissionCollection._PermissionCollection17503 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PermissionCollection))]
	public sealed partial class PermissionCollection_ : java.security.PermissionCollection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PermissionCollection_()
		{
			InitJNI();
		}
		internal PermissionCollection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add17504;
		public override void add(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.PermissionCollection_._add17504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._add17504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implies17505;
		public override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection_._implies17505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._implies17505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements17506;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PermissionCollection_._elements17506)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._elements17506)) as java.util.Enumeration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
			global::java.security.PermissionCollection_._add17504 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.PermissionCollection_._implies17505 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.PermissionCollection_._elements17506 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "elements", "()Ljava/util/Enumeration;");
		}
	}
}
