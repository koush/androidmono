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
		internal static global::MonoJavaBridge.MethodId _add23096;
		public abstract void add(java.security.Permission arg0);
		internal static global::MonoJavaBridge.MethodId _toString23097;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PermissionCollection._toString23097)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._toString23097)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _implies23098;
		public abstract bool implies(java.security.Permission arg0);
		internal static global::MonoJavaBridge.MethodId _setReadOnly23099;
		public virtual void setReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.PermissionCollection._setReadOnly23099);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._setReadOnly23099);
		}
		internal static global::MonoJavaBridge.MethodId _elements23100;
		public abstract global::java.util.Enumeration elements();
		internal static global::MonoJavaBridge.MethodId _isReadOnly23101;
		public virtual bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection._isReadOnly23101);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._isReadOnly23101);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionCollection23102;
		public PermissionCollection()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._PermissionCollection23102);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
			global::java.security.PermissionCollection._add23096 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.PermissionCollection._toString23097 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.PermissionCollection._implies23098 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.PermissionCollection._setReadOnly23099 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "setReadOnly", "()V");
			global::java.security.PermissionCollection._elements23100 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.PermissionCollection._isReadOnly23101 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "isReadOnly", "()Z");
			global::java.security.PermissionCollection._PermissionCollection23102 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _add23103;
		public override void add(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.PermissionCollection_._add23103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._add23103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implies23104;
		public override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection_._implies23104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._implies23104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements23105;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PermissionCollection_._elements23105)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._elements23105)) as java.util.Enumeration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
			global::java.security.PermissionCollection_._add23103 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.PermissionCollection_._implies23104 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.PermissionCollection_._elements23105 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "elements", "()Ljava/util/Enumeration;");
		}
	}
}
