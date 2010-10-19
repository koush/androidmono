namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLEngineResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLEngineResult()
		{
			InitJNI();
		}
		protected SSLEngineResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class HandshakeStatus : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static HandshakeStatus()
			{
				InitJNI();
			}
			internal HandshakeStatus(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values23418;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._values23418)) as javax.net.ssl.SSLEngineResult.HandshakeStatus[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf23419;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._valueOf23419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			}
			internal static global::MonoJavaBridge.FieldId _NOT_HANDSHAKING23420;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NOT_HANDSHAKING
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.HandshakeStatus);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED23421;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus FINISHED
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.HandshakeStatus);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_TASK23422;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_TASK
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.HandshakeStatus);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_WRAP23423;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_WRAP
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.HandshakeStatus);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_UNWRAP23424;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.HandshakeStatus);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$HandshakeStatus"));
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._values23418 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._valueOf23419 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Status : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Status()
			{
				InitJNI();
			}
			internal Status(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values23425;
			public static global::javax.net.ssl.SSLEngineResult.Status[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.Status>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._values23425)) as javax.net.ssl.SSLEngineResult.Status[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf23426;
			public static global::javax.net.ssl.SSLEngineResult.Status valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._valueOf23426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.Status;
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_UNDERFLOW23427;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_UNDERFLOW
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.Status);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_OVERFLOW23428;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_OVERFLOW
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.Status);
				}
			}
			internal static global::MonoJavaBridge.FieldId _OK23429;
			public static global::javax.net.ssl.SSLEngineResult.Status OK
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.Status);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLOSED23430;
			public static global::javax.net.ssl.SSLEngineResult.Status CLOSED
			{
				get
				{
					return default(global::javax.net.ssl.SSLEngineResult.Status);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$Status"));
				global::javax.net.ssl.SSLEngineResult.Status._values23425 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/Status;");
				global::javax.net.ssl.SSLEngineResult.Status._valueOf23426 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString23431;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._toString23431)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._toString23431)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStatus23432;
		public virtual global::javax.net.ssl.SSLEngineResult.Status getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._getStatus23432)) as javax.net.ssl.SSLEngineResult.Status;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._getStatus23432)) as javax.net.ssl.SSLEngineResult.Status;
		}
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus23433;
		public virtual global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._getHandshakeStatus23433)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._getHandshakeStatus23433)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		internal static global::MonoJavaBridge.MethodId _bytesConsumed23434;
		public virtual int bytesConsumed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._bytesConsumed23434);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._bytesConsumed23434);
		}
		internal static global::MonoJavaBridge.MethodId _bytesProduced23435;
		public virtual int bytesProduced() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._bytesProduced23435);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._bytesProduced23435);
		}
		internal static global::MonoJavaBridge.MethodId _SSLEngineResult23436;
		public SSLEngineResult(javax.net.ssl.SSLEngineResult.Status arg0, javax.net.ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._SSLEngineResult23436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngineResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult"));
			global::javax.net.ssl.SSLEngineResult._toString23431 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLEngineResult._getStatus23432 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;");
			global::javax.net.ssl.SSLEngineResult._getHandshakeStatus23433 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			global::javax.net.ssl.SSLEngineResult._bytesConsumed23434 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "bytesConsumed", "()I");
			global::javax.net.ssl.SSLEngineResult._bytesProduced23435 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "bytesProduced", "()I");
			global::javax.net.ssl.SSLEngineResult._SSLEngineResult23436 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "<init>", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;II)V");
		}
	}
}
