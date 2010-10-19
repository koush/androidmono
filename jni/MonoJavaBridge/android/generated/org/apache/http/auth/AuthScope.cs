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
		internal static global::MonoJavaBridge.MethodId _equals25129;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._equals25129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._equals25129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25130;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._toString25130)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._toString25130)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25131;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._hashCode25131);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._hashCode25131);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme25132;
		public virtual global::java.lang.String getScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getScheme25132)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getScheme25132)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort25133;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getPort25133);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getPort25133);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost25134;
		public virtual global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getHost25134)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getHost25134)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _match25135;
		public virtual int match(org.apache.http.auth.AuthScope arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._match25135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._match25135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Realm
		{
			get
			{
				return getRealm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRealm25136;
		public virtual global::java.lang.String getRealm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope._getRealm25136)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getRealm25136)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope25137;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope25137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope25138;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope25138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope25139;
		public AuthScope(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope25139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope25140;
		public AuthScope(org.apache.http.auth.AuthScope arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope25140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ANY_HOST25141;
		public static global::java.lang.String ANY_HOST
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		public static int ANY_PORT
		{
			get
			{
				return -1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_REALM25142;
		public static global::java.lang.String ANY_REALM
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_SCHEME25143;
		public static global::java.lang.String ANY_SCHEME
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY25144;
		public static global::org.apache.http.auth.AuthScope ANY
		{
			get
			{
				return default(global::org.apache.http.auth.AuthScope);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthScope.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthScope"));
			global::org.apache.http.auth.AuthScope._equals25129 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.AuthScope._toString25130 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._hashCode25131 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.AuthScope._getScheme25132 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getScheme", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._getPort25133 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getPort", "()I");
			global::org.apache.http.auth.AuthScope._getHost25134 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getHost", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._match25135 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "match", "(Lorg/apache/http/auth/AuthScope;)I");
			global::org.apache.http.auth.AuthScope._getRealm25136 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._AuthScope25137 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.auth.AuthScope._AuthScope25138 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::org.apache.http.auth.AuthScope._AuthScope25139 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::org.apache.http.auth.AuthScope._AuthScope25140 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Lorg/apache/http/auth/AuthScope;)V");
		}
	}
}
