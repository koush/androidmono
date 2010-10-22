namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.Authenticator_))]
	public abstract partial class Authenticator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Authenticator()
		{
			InitJNI();
		}
		protected Authenticator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class RequestorType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RequestorType()
			{
				InitJNI();
			}
			internal RequestorType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values21210;
			public static global::java.net.Authenticator.RequestorType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.net.Authenticator.RequestorType>(@__env.CallStaticObjectMethod(java.net.Authenticator.RequestorType.staticClass, global::java.net.Authenticator.RequestorType._values21210)) as java.net.Authenticator.RequestorType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf21211;
			public static global::java.net.Authenticator.RequestorType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.CallStaticObjectMethod(java.net.Authenticator.RequestorType.staticClass, global::java.net.Authenticator.RequestorType._valueOf21211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.Authenticator.RequestorType;
			}
			internal static global::MonoJavaBridge.FieldId _PROXY21212;
			public static global::java.net.Authenticator.RequestorType PROXY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.GetStaticObjectField(global::java.net.Authenticator.RequestorType.staticClass, _PROXY21212)) as java.net.Authenticator.RequestorType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SERVER21213;
			public static global::java.net.Authenticator.RequestorType SERVER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.GetStaticObjectField(global::java.net.Authenticator.RequestorType.staticClass, _SERVER21213)) as java.net.Authenticator.RequestorType;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.net.Authenticator.RequestorType.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator$RequestorType"));
				global::java.net.Authenticator.RequestorType._values21210 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "values", "()[Ljava/net/Authenticator/RequestorType;");
				global::java.net.Authenticator.RequestorType._valueOf21211 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/net/Authenticator$RequestorType;");
				global::java.net.Authenticator.RequestorType._PROXY21212 = @__env.GetStaticFieldIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "PROXY", "Ljava/net/Authenticator$RequestorType;");
				global::java.net.Authenticator.RequestorType._SERVER21213 = @__env.GetStaticFieldIDNoThrow(global::java.net.Authenticator.RequestorType.staticClass, "SERVER", "Ljava/net/Authenticator$RequestorType;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDefault21214;
		public static void setDefault(java.net.Authenticator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._setDefault21214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestPasswordAuthentication21215;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.net.InetAddress arg0, int arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._requestPasswordAuthentication21215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _requestPasswordAuthentication21216;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.lang.String arg0, java.net.InetAddress arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._requestPasswordAuthentication21216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _requestPasswordAuthentication21217;
		public static global::java.net.PasswordAuthentication requestPasswordAuthentication(java.lang.String arg0, java.net.InetAddress arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.net.URL arg6, java.net.Authenticator.RequestorType arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallStaticObjectMethod(java.net.Authenticator.staticClass, global::java.net.Authenticator._requestPasswordAuthentication21217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingHost21218;
		protected virtual global::java.lang.String getRequestingHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getRequestingHost21218)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestingHost21218)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingSite21219;
		protected virtual global::java.net.InetAddress getRequestingSite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getRequestingSite21219)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestingSite21219)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingPort21220;
		protected virtual int getRequestingPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.Authenticator._getRequestingPort21220);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestingPort21220);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingProtocol21221;
		protected virtual global::java.lang.String getRequestingProtocol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getRequestingProtocol21221)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestingProtocol21221)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingPrompt21222;
		protected virtual global::java.lang.String getRequestingPrompt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getRequestingPrompt21222)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestingPrompt21222)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingScheme21223;
		protected virtual global::java.lang.String getRequestingScheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getRequestingScheme21223)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestingScheme21223)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordAuthentication21224;
		protected virtual global::java.net.PasswordAuthentication getPasswordAuthentication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getPasswordAuthentication21224)) as java.net.PasswordAuthentication;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.PasswordAuthentication>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getPasswordAuthentication21224)) as java.net.PasswordAuthentication;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestingURL21225;
		protected virtual global::java.net.URL getRequestingURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getRequestingURL21225)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestingURL21225)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestorType21226;
		protected virtual global::java.net.Authenticator.RequestorType getRequestorType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.Authenticator._getRequestorType21226)) as java.net.Authenticator.RequestorType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.Authenticator.RequestorType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.Authenticator.staticClass, global::java.net.Authenticator._getRequestorType21226)) as java.net.Authenticator.RequestorType;
		}
		internal static global::MonoJavaBridge.MethodId _Authenticator21227;
		public Authenticator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.Authenticator.staticClass, global::java.net.Authenticator._Authenticator21227);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Authenticator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator"));
			global::java.net.Authenticator._setDefault21214 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "setDefault", "(Ljava/net/Authenticator;)V");
			global::java.net.Authenticator._requestPasswordAuthentication21215 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;");
			global::java.net.Authenticator._requestPasswordAuthentication21216 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/PasswordAuthentication;");
			global::java.net.Authenticator._requestPasswordAuthentication21217 = @__env.GetStaticMethodIDNoThrow(global::java.net.Authenticator.staticClass, "requestPasswordAuthentication", "(Ljava/lang/String;Ljava/net/InetAddress;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;Ljava/net/Authenticator$RequestorType;)Ljava/net/PasswordAuthentication;");
			global::java.net.Authenticator._getRequestingHost21218 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestingHost", "()Ljava/lang/String;");
			global::java.net.Authenticator._getRequestingSite21219 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestingSite", "()Ljava/net/InetAddress;");
			global::java.net.Authenticator._getRequestingPort21220 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestingPort", "()I");
			global::java.net.Authenticator._getRequestingProtocol21221 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestingProtocol", "()Ljava/lang/String;");
			global::java.net.Authenticator._getRequestingPrompt21222 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestingPrompt", "()Ljava/lang/String;");
			global::java.net.Authenticator._getRequestingScheme21223 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestingScheme", "()Ljava/lang/String;");
			global::java.net.Authenticator._getPasswordAuthentication21224 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getPasswordAuthentication", "()Ljava/net/PasswordAuthentication;");
			global::java.net.Authenticator._getRequestingURL21225 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestingURL", "()Ljava/net/URL;");
			global::java.net.Authenticator._getRequestorType21226 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "getRequestorType", "()Ljava/net/Authenticator$RequestorType;");
			global::java.net.Authenticator._Authenticator21227 = @__env.GetMethodIDNoThrow(global::java.net.Authenticator.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.Authenticator))]
	public sealed partial class Authenticator_ : java.net.Authenticator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Authenticator_()
		{
			InitJNI();
		}
		internal Authenticator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.Authenticator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/Authenticator"));
		}
	}
}
