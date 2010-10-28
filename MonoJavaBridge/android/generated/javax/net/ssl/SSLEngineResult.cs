namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLEngineResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLEngineResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class HandshakeStatus : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal HandshakeStatus(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values29968;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._values29968)) as javax.net.ssl.SSLEngineResult.HandshakeStatus[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf29969;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._valueOf29969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			}
			internal static global::MonoJavaBridge.FieldId _NOT_HANDSHAKING29970;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NOT_HANDSHAKING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NOT_HANDSHAKING29970)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED29971;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus FINISHED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _FINISHED29971)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_TASK29972;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_TASK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_TASK29972)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_WRAP29973;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_WRAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_WRAP29973)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_UNWRAP29974;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_UNWRAP29974)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			static HandshakeStatus()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$HandshakeStatus"));
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._values29968 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._valueOf29969 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NOT_HANDSHAKING29970 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NOT_HANDSHAKING", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._FINISHED29971 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "FINISHED", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_TASK29972 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_TASK", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_WRAP29973 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_WRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_UNWRAP29974 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_UNWRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Status : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Status(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values29975;
			public static global::javax.net.ssl.SSLEngineResult.Status[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.Status>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._values29975)) as javax.net.ssl.SSLEngineResult.Status[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf29976;
			public static global::javax.net.ssl.SSLEngineResult.Status valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._valueOf29976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.Status;
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_UNDERFLOW29977;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_UNDERFLOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _BUFFER_UNDERFLOW29977)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_OVERFLOW29978;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_OVERFLOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _BUFFER_OVERFLOW29978)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OK29979;
			public static global::javax.net.ssl.SSLEngineResult.Status OK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _OK29979)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLOSED29980;
			public static global::javax.net.ssl.SSLEngineResult.Status CLOSED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _CLOSED29980)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			static Status()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$Status"));
				global::javax.net.ssl.SSLEngineResult.Status._values29975 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/Status;");
				global::javax.net.ssl.SSLEngineResult.Status._valueOf29976 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._BUFFER_UNDERFLOW29977 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "BUFFER_UNDERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._BUFFER_OVERFLOW29978 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "BUFFER_OVERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._OK29979 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "OK", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._CLOSED29980 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "CLOSED", "Ljavax/net/ssl/SSLEngineResult$Status;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString29981;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._toString29981)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._toString29981)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStatus29982;
		public virtual global::javax.net.ssl.SSLEngineResult.Status getStatus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._getStatus29982)) as javax.net.ssl.SSLEngineResult.Status;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._getStatus29982)) as javax.net.ssl.SSLEngineResult.Status;
		}
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29983;
		public virtual global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._getHandshakeStatus29983)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._getHandshakeStatus29983)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		internal static global::MonoJavaBridge.MethodId _bytesConsumed29984;
		public virtual int bytesConsumed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._bytesConsumed29984);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._bytesConsumed29984);
		}
		internal static global::MonoJavaBridge.MethodId _bytesProduced29985;
		public virtual int bytesProduced()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._bytesProduced29985);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._bytesProduced29985);
		}
		internal static global::MonoJavaBridge.MethodId _SSLEngineResult29986;
		public SSLEngineResult(javax.net.ssl.SSLEngineResult.Status arg0, javax.net.ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._SSLEngineResult29986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SSLEngineResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngineResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult"));
			global::javax.net.ssl.SSLEngineResult._toString29981 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLEngineResult._getStatus29982 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;");
			global::javax.net.ssl.SSLEngineResult._getHandshakeStatus29983 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			global::javax.net.ssl.SSLEngineResult._bytesConsumed29984 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "bytesConsumed", "()I");
			global::javax.net.ssl.SSLEngineResult._bytesProduced29985 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "bytesProduced", "()I");
			global::javax.net.ssl.SSLEngineResult._SSLEngineResult29986 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "<init>", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;II)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
