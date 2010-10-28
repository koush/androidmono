namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.PermissionCollection_))]
	public abstract partial class PermissionCollection : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PermissionCollection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add23215;
		public abstract void add(java.security.Permission arg0);
		internal static global::MonoJavaBridge.MethodId _toString23216;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PermissionCollection._toString23216)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._toString23216)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _implies23217;
		public abstract bool implies(java.security.Permission arg0);
		internal static global::MonoJavaBridge.MethodId _setReadOnly23218;
		public virtual void setReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.PermissionCollection._setReadOnly23218);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._setReadOnly23218);
		}
		internal static global::MonoJavaBridge.MethodId _elements23219;
		public abstract global::java.util.Enumeration elements();
		internal static global::MonoJavaBridge.MethodId _isReadOnly23220;
		public virtual bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection._isReadOnly23220);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._isReadOnly23220);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionCollection23221;
		public PermissionCollection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._PermissionCollection23221);
			Init(@__env, handle);
		}
		static PermissionCollection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
			global::java.security.PermissionCollection._add23215 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.PermissionCollection._toString23216 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.PermissionCollection._implies23217 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.PermissionCollection._setReadOnly23218 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "setReadOnly", "()V");
			global::java.security.PermissionCollection._elements23219 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.PermissionCollection._isReadOnly23220 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "isReadOnly", "()Z");
			global::java.security.PermissionCollection._PermissionCollection23221 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PermissionCollection))]
	internal sealed partial class PermissionCollection_ : java.security.PermissionCollection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PermissionCollection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add23222;
		public override void add(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.PermissionCollection_._add23222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._add23222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implies23223;
		public override bool implies(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection_._implies23223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._implies23223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _elements23224;
		public override global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PermissionCollection_._elements23224)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PermissionCollection_.staticClass, global::java.security.PermissionCollection_._elements23224)) as java.util.Enumeration;
		}
		static PermissionCollection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
			global::java.security.PermissionCollection_._add23222 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "add", "(Ljava/security/Permission;)V");
			global::java.security.PermissionCollection_._implies23223 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.PermissionCollection_._elements23224 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection_.staticClass, "elements", "()Ljava/util/Enumeration;");
		}
		internal static void InitJNI()
		{
		}
	}
}
