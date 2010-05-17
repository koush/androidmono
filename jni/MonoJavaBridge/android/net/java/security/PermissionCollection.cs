namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class PermissionCollection : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static PermissionCollection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.PermissionCollection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected PermissionCollection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add11581; 
		public abstract void add(java.security.Permission arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _toString11582; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.PermissionCollection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11582)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.PermissionCollection.staticClass, _toString11582)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implies11583; 
		public abstract bool implies(java.security.Permission arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setReadOnly11584; 
		public virtual void setReadOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.PermissionCollection)) 
				@__env.CallVoidMethod(this, _setReadOnly11584); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.security.PermissionCollection.staticClass, _setReadOnly11584); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _elements11585; 
		public abstract java.util.Enumeration elements(); 
		internal static global::net.sf.jni4net.jni.MethodId _isReadOnly11586; 
		public virtual bool isReadOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.PermissionCollection)) 
				return @__env.CallBooleanMethod(this, _isReadOnly11586); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.PermissionCollection.staticClass, _isReadOnly11586); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PermissionCollection11587; 
		public PermissionCollection()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.PermissionCollection.staticClass, _PermissionCollection11587, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.PermissionCollection.staticClass = @__class; 
			global::java.security.PermissionCollection._add11581 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "add", "(Ljava/security/Permission;)V"); 
			global::java.security.PermissionCollection._toString11582 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.PermissionCollection._implies11583 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "implies", "(Ljava/security/Permission;)Z"); 
			global::java.security.PermissionCollection._setReadOnly11584 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "setReadOnly", "()V"); 
			global::java.security.PermissionCollection._elements11585 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "elements", "()Ljava/util/Enumeration;"); 
			global::java.security.PermissionCollection._isReadOnly11586 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "isReadOnly", "()Z"); 
			global::java.security.PermissionCollection._PermissionCollection11587 = @__env.GetMethodID(global::java.security.PermissionCollection.staticClass, "<init>", "()V"); 
		} 
	} 
} 
