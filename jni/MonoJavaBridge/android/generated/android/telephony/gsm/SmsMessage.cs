namespace android.telephony.gsm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SmsMessage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SmsMessage()
		{
			InitJNI();
		}
		protected SmsMessage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class MessageClass : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MessageClass()
			{
				InitJNI();
			}
			internal MessageClass(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values7543;
			public static global::android.telephony.gsm.SmsMessage.MessageClass[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._values7543)) as android.telephony.gsm.SmsMessage.MessageClass[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7544;
			public static global::android.telephony.gsm.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._valueOf7544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage.MessageClass;
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_07545;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_17546;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_27547;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_37548;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN7549;
			public static global::android.telephony.gsm.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.MessageClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$MessageClass"));
				global::android.telephony.gsm.SmsMessage.MessageClass._values7543 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/gsm/SmsMessage/MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._valueOf7544 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SubmitPdu : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SubmitPdu()
			{
				InitJNI();
			}
			protected SubmitPdu(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString7550;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString7550)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString7550)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _SubmitPdu7551;
			public SubmitPdu()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu7551);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _encodedScAddress7552;
			public byte[] encodedScAddress
			{
				get
				{
					return default(byte[]);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _encodedMessage7553;
			public byte[] encodedMessage
			{
				get
				{
					return default(byte[]);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$SubmitPdu"));
				global::android.telephony.gsm.SmsMessage.SubmitPdu._toString7550 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu7551 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "<init>", "()V");
			}
		}
		public new byte[] UserData
		{
			get
			{
				return getUserData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserData7554;
		public virtual byte[] getUserData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getUserData7554)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getUserData7554)) as byte[];
		}
		public new int Status
		{
			get
			{
				return getStatus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatus7555;
		public virtual int getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getStatus7555);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatus7555);
		}
		internal static global::MonoJavaBridge.MethodId _createFromPdu7556;
		public static global::android.telephony.gsm.SmsMessage createFromPdu(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._createFromPdu7556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage;
		}
		internal static global::MonoJavaBridge.MethodId _getTPLayerLengthForPDU7557;
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU7557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength7558;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength7558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength7559;
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength7559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu7560;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu7560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu7561;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu7561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		public new global::java.lang.String ServiceCenterAddress
		{
			get
			{
				return getServiceCenterAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceCenterAddress7562;
		public virtual global::java.lang.String getServiceCenterAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress7562)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress7562)) as java.lang.String;
		}
		public new global::java.lang.String OriginatingAddress
		{
			get
			{
				return getOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginatingAddress7563;
		public virtual global::java.lang.String getOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getOriginatingAddress7563)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getOriginatingAddress7563)) as java.lang.String;
		}
		public new global::java.lang.String DisplayOriginatingAddress
		{
			get
			{
				return getDisplayOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayOriginatingAddress7564;
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress7564)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress7564)) as java.lang.String;
		}
		public new global::java.lang.String MessageBody
		{
			get
			{
				return getMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageBody7565;
		public virtual global::java.lang.String getMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getMessageBody7565)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageBody7565)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMessageClass7566;
		public virtual global::android.telephony.gsm.SmsMessage.MessageClass getMessageClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getMessageClass7566)) as android.telephony.gsm.SmsMessage.MessageClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageClass7566)) as android.telephony.gsm.SmsMessage.MessageClass;
		}
		public new global::java.lang.String DisplayMessageBody
		{
			get
			{
				return getDisplayMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMessageBody7567;
		public virtual global::java.lang.String getDisplayMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody7567)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody7567)) as java.lang.String;
		}
		public new global::java.lang.String PseudoSubject
		{
			get
			{
				return getPseudoSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPseudoSubject7568;
		public virtual global::java.lang.String getPseudoSubject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getPseudoSubject7568)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPseudoSubject7568)) as java.lang.String;
		}
		public new long TimestampMillis
		{
			get
			{
				return getTimestampMillis();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimestampMillis7569;
		public virtual long getTimestampMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getTimestampMillis7569);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTimestampMillis7569);
		}
		internal static global::MonoJavaBridge.MethodId _isEmail7570;
		public virtual bool isEmail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isEmail7570);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isEmail7570);
		}
		public new global::java.lang.String EmailBody
		{
			get
			{
				return getEmailBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailBody7571;
		public virtual global::java.lang.String getEmailBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getEmailBody7571)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailBody7571)) as java.lang.String;
		}
		public new global::java.lang.String EmailFrom
		{
			get
			{
				return getEmailFrom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailFrom7572;
		public virtual global::java.lang.String getEmailFrom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getEmailFrom7572)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailFrom7572)) as java.lang.String;
		}
		public new int ProtocolIdentifier
		{
			get
			{
				return getProtocolIdentifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolIdentifier7573;
		public virtual int getProtocolIdentifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier7573);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier7573);
		}
		internal static global::MonoJavaBridge.MethodId _isReplace7574;
		public virtual bool isReplace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isReplace7574);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplace7574);
		}
		internal static global::MonoJavaBridge.MethodId _isCphsMwiMessage7575;
		public virtual bool isCphsMwiMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage7575);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage7575);
		}
		internal static global::MonoJavaBridge.MethodId _isMWIClearMessage7576;
		public virtual bool isMWIClearMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMWIClearMessage7576);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWIClearMessage7576);
		}
		internal static global::MonoJavaBridge.MethodId _isMWISetMessage7577;
		public virtual bool isMWISetMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMWISetMessage7577);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWISetMessage7577);
		}
		internal static global::MonoJavaBridge.MethodId _isMwiDontStore7578;
		public virtual bool isMwiDontStore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMwiDontStore7578);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMwiDontStore7578);
		}
		public new byte[] Pdu
		{
			get
			{
				return getPdu();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPdu7579;
		public virtual byte[] getPdu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getPdu7579)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPdu7579)) as byte[];
		}
		public new int StatusOnSim
		{
			get
			{
				return getStatusOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusOnSim7580;
		public virtual int getStatusOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getStatusOnSim7580);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatusOnSim7580);
		}
		public new int IndexOnSim
		{
			get
			{
				return getIndexOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexOnSim7581;
		public virtual int getIndexOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getIndexOnSim7581);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getIndexOnSim7581);
		}
		internal static global::MonoJavaBridge.MethodId _isStatusReportMessage7582;
		public virtual bool isStatusReportMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isStatusReportMessage7582);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isStatusReportMessage7582);
		}
		internal static global::MonoJavaBridge.MethodId _isReplyPathPresent7583;
		public virtual bool isReplyPathPresent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isReplyPathPresent7583);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplyPathPresent7583);
		}
		internal static global::MonoJavaBridge.MethodId _SmsMessage7584;
		public SmsMessage()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._SmsMessage7584);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.gsm.SmsMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage"));
			global::android.telephony.gsm.SmsMessage._getUserData7554 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatus7555 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.gsm.SmsMessage._createFromPdu7556 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;");
			global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU7557 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.gsm.SmsMessage._calculateLength7558 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.gsm.SmsMessage._calculateLength7559 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu7560 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu7561 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getServiceCenterAddress7562 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getOriginatingAddress7563 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress7564 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageBody7565 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageClass7566 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;");
			global::android.telephony.gsm.SmsMessage._getDisplayMessageBody7567 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getPseudoSubject7568 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getTimestampMillis7569 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.gsm.SmsMessage._isEmail7570 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.gsm.SmsMessage._getEmailBody7571 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getEmailFrom7572 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getProtocolIdentifier7573 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.gsm.SmsMessage._isReplace7574 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.gsm.SmsMessage._isCphsMwiMessage7575 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWIClearMessage7576 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWISetMessage7577 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMwiDontStore7578 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.gsm.SmsMessage._getPdu7579 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatusOnSim7580 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._getIndexOnSim7581 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._isStatusReportMessage7582 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isReplyPathPresent7583 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
			global::android.telephony.gsm.SmsMessage._SmsMessage7584 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "<init>", "()V");
		}
	}
}
