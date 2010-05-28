namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class PermissionCollection : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static PermissionCollection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.PermissionCollection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected PermissionCollection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add12449; 
		public abstract void add(java.security.Permission arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _toString12450; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.PermissionCollection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.PermissionCollection._toString12450)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._toString12450)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implies12451; 
		public abstract bool implies(java.security.Permission arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setReadOnly12452; 
		public virtual void setReadOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.PermissionCollection)) 
				@__env.CallVoidMethod(this, global::java.security.PermissionCollection._setReadOnly12452); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._setReadOnly12452); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _elements12453; 
		public abstract global::java.util.Enumeration elements(); 
		internal static global::net.sf.jni4net.jni.MethodId _isReadOnly12454; 
		public virtual bool isReadOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.PermissionCollection)) 
				return @__env.CallBooleanMethod(this, global::java.security.PermissionCollection._isReadOnly12454); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._isReadOnly12454); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PermissionCollection12455; 
		public PermissionCollection()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._PermissionCollection12455, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.PermissionCollection.staticClass = @__class; 
			global::java.security.PermissionCollection._add12449 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "add", "(Ljava/security/Permission;)V"); 
			global::java.security.PermissionCollection._toString12450 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.PermissionCollection._implies12451 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "implies", "(Ljava/security/Permission;)Z"); 
			global::java.security.PermissionCollection._setReadOnly12452 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "setReadOnly", "()V"); 
			global::java.security.PermissionCollection._elements12453 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "elements", "()Ljava/util/Enumeration;"); 
			global::java.security.PermissionCollection._isReadOnly12454 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "isReadOnly", "()Z"); 
			global::java.security.PermissionCollection._PermissionCollection12455 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "<init>", "()V"); 
		} 
	} 
} 
