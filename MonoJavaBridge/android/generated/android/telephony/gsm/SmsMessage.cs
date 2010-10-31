namespace android.telephony.gsm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SmsMessage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SmsMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class MessageClass : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal MessageClass(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.telephony.gsm.SmsMessage.MessageClass[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.telephony.gsm.SmsMessage.MessageClass._m0.native == global::System.IntPtr.Zero)
					global::android.telephony.gsm.SmsMessage.MessageClass._m0 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/gsm/SmsMessage/MessageClass;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._m0)) as android.telephony.gsm.SmsMessage.MessageClass[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.telephony.gsm.SmsMessage.MessageClass valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.telephony.gsm.SmsMessage.MessageClass._m1.native == global::System.IntPtr.Zero)
					global::android.telephony.gsm.SmsMessage.MessageClass._m1 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage.MessageClass;
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_05168;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_05168)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_15169;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_15169)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_25170;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_25170)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_35171;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_35171)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN5172;
			public static global::android.telephony.gsm.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _UNKNOWN5172)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			static MessageClass()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.MessageClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$MessageClass"));
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_05168 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_0", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_15169 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_1", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_25170 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_2", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_35171 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_3", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._UNKNOWN5172 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "UNKNOWN", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SubmitPdu : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SubmitPdu(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage.SubmitPdu._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public SubmitPdu() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.telephony.gsm.SmsMessage.SubmitPdu._m1.native == global::System.IntPtr.Zero)
					global::android.telephony.gsm.SmsMessage.SubmitPdu._m1 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._m1);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _encodedScAddress5173;
			public byte[] encodedScAddress
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedScAddress5173)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _encodedMessage5174;
			public byte[] encodedMessage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedMessage5174)) as byte[];
				}
				set
				{
				}
			}
			static SubmitPdu()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$SubmitPdu"));
				global::android.telephony.gsm.SmsMessage.SubmitPdu._encodedScAddress5173 = @__env.GetFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "encodedScAddress", "[B");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._encodedMessage5174 = @__env.GetFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "encodedMessage", "[B");
			}
		}
		public new byte[] UserData
		{
			get
			{
				return getUserData();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual byte[] getUserData()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getUserData", "()[B", ref global::android.telephony.gsm.SmsMessage._m0) as byte[];
		}
		public new int Status
		{
			get
			{
				return getStatus();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "getStatus", "()I", ref global::android.telephony.gsm.SmsMessage._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.telephony.gsm.SmsMessage createFromPdu(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsMessage._m2.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsMessage._m2 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int getTPLayerLengthForPDU(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsMessage._m3.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsMessage._m3 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsMessage._m4.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsMessage._m4 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		public static int[] calculateLength(string arg0, bool arg1)
		{
			return calculateLength((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int[] calculateLength(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsMessage._m5.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsMessage._m5 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsMessage._m6.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsMessage._m6 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsMessage._m7.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsMessage._m7 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		public new global::java.lang.String ServiceCenterAddress
		{
			get
			{
				return getServiceCenterAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getServiceCenterAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m8) as java.lang.String;
		}
		public new global::java.lang.String OriginatingAddress
		{
			get
			{
				return getOriginatingAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getOriginatingAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m9) as java.lang.String;
		}
		public new global::java.lang.String DisplayOriginatingAddress
		{
			get
			{
				return getDisplayOriginatingAddress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String getDisplayOriginatingAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m10) as java.lang.String;
		}
		public new global::java.lang.String MessageBody
		{
			get
			{
				return getMessageBody();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getMessageBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.telephony.gsm.SmsMessage.MessageClass getMessageClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.telephony.gsm.SmsMessage.MessageClass>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;", ref global::android.telephony.gsm.SmsMessage._m12) as android.telephony.gsm.SmsMessage.MessageClass;
		}
		public new global::java.lang.String DisplayMessageBody
		{
			get
			{
				return getDisplayMessageBody();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getDisplayMessageBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m13) as java.lang.String;
		}
		public new global::java.lang.String PseudoSubject
		{
			get
			{
				return getPseudoSubject();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.String getPseudoSubject()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m14) as java.lang.String;
		}
		public new long TimestampMillis
		{
			get
			{
				return getTimestampMillis();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual long getTimestampMillis()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "getTimestampMillis", "()J", ref global::android.telephony.gsm.SmsMessage._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool isEmail()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isEmail", "()Z", ref global::android.telephony.gsm.SmsMessage._m16);
		}
		public new global::java.lang.String EmailBody
		{
			get
			{
				return getEmailBody();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getEmailBody()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m17) as java.lang.String;
		}
		public new global::java.lang.String EmailFrom
		{
			get
			{
				return getEmailFrom();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String getEmailFrom()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;", ref global::android.telephony.gsm.SmsMessage._m18) as java.lang.String;
		}
		public new int ProtocolIdentifier
		{
			get
			{
				return getProtocolIdentifier();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getProtocolIdentifier()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "getProtocolIdentifier", "()I", ref global::android.telephony.gsm.SmsMessage._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isReplace()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isReplace", "()Z", ref global::android.telephony.gsm.SmsMessage._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isCphsMwiMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isCphsMwiMessage", "()Z", ref global::android.telephony.gsm.SmsMessage._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isMWIClearMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isMWIClearMessage", "()Z", ref global::android.telephony.gsm.SmsMessage._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isMWISetMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isMWISetMessage", "()Z", ref global::android.telephony.gsm.SmsMessage._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isMwiDontStore()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isMwiDontStore", "()Z", ref global::android.telephony.gsm.SmsMessage._m24);
		}
		public new byte[] Pdu
		{
			get
			{
				return getPdu();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual byte[] getPdu()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.telephony.gsm.SmsMessage.staticClass, "getPdu", "()[B", ref global::android.telephony.gsm.SmsMessage._m25) as byte[];
		}
		public new int StatusOnSim
		{
			get
			{
				return getStatusOnSim();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int getStatusOnSim()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "getStatusOnSim", "()I", ref global::android.telephony.gsm.SmsMessage._m26);
		}
		public new int IndexOnSim
		{
			get
			{
				return getIndexOnSim();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getIndexOnSim()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "getIndexOnSim", "()I", ref global::android.telephony.gsm.SmsMessage._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool isStatusReportMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isStatusReportMessage", "()Z", ref global::android.telephony.gsm.SmsMessage._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool isReplyPathPresent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, "isReplyPathPresent", "()Z", ref global::android.telephony.gsm.SmsMessage._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public SmsMessage() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsMessage._m30.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsMessage._m30 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._m30);
			Init(@__env, handle);
		}
		public static int ENCODING_UNKNOWN
		{
			get
			{
				return 0;
			}
		}
		public static int ENCODING_7BIT
		{
			get
			{
				return 1;
			}
		}
		public static int ENCODING_8BIT
		{
			get
			{
				return 2;
			}
		}
		public static int ENCODING_16BIT
		{
			get
			{
				return 3;
			}
		}
		public static int MAX_USER_DATA_BYTES
		{
			get
			{
				return 140;
			}
		}
		public static int MAX_USER_DATA_SEPTETS
		{
			get
			{
				return 160;
			}
		}
		public static int MAX_USER_DATA_SEPTETS_WITH_HEADER
		{
			get
			{
				return 153;
			}
		}
		static SmsMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.gsm.SmsMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage"));
		}
	}
}
