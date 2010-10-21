namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthScope : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthScope()
		{
			InitJNI();
		}
		protected AuthScope(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31672;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._equals31672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._equals31672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31673;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._toString31673)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._toString31673)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31674;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._hashCode31674);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._hashCode31674);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme31675;
		public virtual global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getScheme31675)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getScheme31675)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort31676;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getPort31676);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getPort31676);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost31677;
		public virtual global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getHost31677)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getHost31677)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _match31678;
		public virtual int match(org.apache.http.auth.AuthScope arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._match31678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._match31678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Realm
		{
			get
			{
				return getRealm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRealm31679;
		public virtual global::java.lang.String getRealm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getRealm31679)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getRealm31679)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31680;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31681;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31682;
		public AuthScope(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31683;
		public AuthScope(org.apache.http.auth.AuthScope arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ANY_HOST31684;
		public static global::java.lang.String ANY_HOST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_HOST31684)) as java.lang.String;
			}
		}
		public static int ANY_PORT
		{
			get
			{
				return -1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_REALM31686;
		public static global::java.lang.String ANY_REALM
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_REALM31686)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_SCHEME31687;
		public static global::java.lang.String ANY_SCHEME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_SCHEME31687)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY31688;
		public static global::org.apache.http.auth.AuthScope ANY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY31688)) as org.apache.http.auth.AuthScope;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthScope.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthScope"));
			global::org.apache.http.auth.AuthScope._equals31672 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.AuthScope._toString31673 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._hashCode31674 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.AuthScope._getScheme31675 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getScheme", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._getPort31676 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getPort", "()I");
			global::org.apache.http.auth.AuthScope._getHost31677 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getHost", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._match31678 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "match", "(Lorg/apache/http/auth/AuthScope;)I");
			global::org.apache.http.auth.AuthScope._getRealm31679 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._AuthScope31680 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.auth.AuthScope._AuthScope31681 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::org.apache.http.auth.AuthScope._AuthScope31682 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::org.apache.http.auth.AuthScope._AuthScope31683 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Lorg/apache/http/auth/AuthScope;)V");
			global::org.apache.http.auth.AuthScope._ANY_HOST31684 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_HOST", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY_REALM31686 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_REALM", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY_SCHEME31687 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_SCHEME", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY31688 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY", "Lorg/apache/http/auth/AuthScope;");
		}
	}
}
