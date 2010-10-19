namespace android.telephony
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
			internal static global::MonoJavaBridge.MethodId _values7445;
			public static global::android.telephony.SmsMessage.MessageClass[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.telephony.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._values7445)) as android.telephony.SmsMessage.MessageClass[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7446;
			public static global::android.telephony.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._valueOf7446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.SmsMessage.MessageClass;
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_07447;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_17448;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_27449;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_37450;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN7451;
			public static global::android.telephony.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.SmsMessage.MessageClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SmsMessage$MessageClass"));
				global::android.telephony.SmsMessage.MessageClass._values7445 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/SmsMessage/MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._valueOf7446 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;");
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
			internal static global::MonoJavaBridge.MethodId _toString7452;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.SubmitPdu._toString7452)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.SubmitPdu.staticClass, global::android.telephony.SmsMessage.SubmitPdu._toString7452)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.FieldId _encodedScAddress7453;
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
			internal static global::MonoJavaBridge.FieldId _encodedMessage7454;
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
				global::android.telephony.SmsMessage.SubmitPdu.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SmsMessage$SubmitPdu"));
				global::android.telephony.SmsMessage.SubmitPdu._toString7452 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
			}
		}
		public new byte[] UserData
		{
			get
			{
				return getUserData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserData7455;
		public virtual byte[] getUserData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getUserData7455)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getUserData7455)) as byte[];
		}
		public new int Status
		{
			get
			{
				return getStatus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatus7456;
		public virtual int getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getStatus7456);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatus7456);
		}
		internal static global::MonoJavaBridge.MethodId _createFromPdu7457;
		public static global::android.telephony.SmsMessage createFromPdu(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._createFromPdu7457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.SmsMessage;
		}
		internal static global::MonoJavaBridge.MethodId _getTPLayerLengthForPDU7458;
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTPLayerLengthForPDU7458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength7459;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength7459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength7460;
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength7460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu7461;
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu7461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.telephony.SmsMessage.SubmitPdu;
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu7462;
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu7462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.telephony.SmsMessage.SubmitPdu;
		}
		public new global::java.lang.String ServiceCenterAddress
		{
			get
			{
				return getServiceCenterAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceCenterAddress7463;
		public virtual global::java.lang.String getServiceCenterAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getServiceCenterAddress7463)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getServiceCenterAddress7463)) as java.lang.String;
		}
		public new global::java.lang.String OriginatingAddress
		{
			get
			{
				return getOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginatingAddress7464;
		public virtual global::java.lang.String getOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getOriginatingAddress7464)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getOriginatingAddress7464)) as java.lang.String;
		}
		public new global::java.lang.String DisplayOriginatingAddress
		{
			get
			{
				return getDisplayOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayOriginatingAddress7465;
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getDisplayOriginatingAddress7465)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayOriginatingAddress7465)) as java.lang.String;
		}
		public new global::java.lang.String MessageBody
		{
			get
			{
				return getMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageBody7466;
		public virtual global::java.lang.String getMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getMessageBody7466)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageBody7466)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMessageClass7467;
		public virtual global::android.telephony.SmsMessage.MessageClass getMessageClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getMessageClass7467)) as android.telephony.SmsMessage.MessageClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageClass7467)) as android.telephony.SmsMessage.MessageClass;
		}
		public new global::java.lang.String DisplayMessageBody
		{
			get
			{
				return getDisplayMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMessageBody7468;
		public virtual global::java.lang.String getDisplayMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getDisplayMessageBody7468)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayMessageBody7468)) as java.lang.String;
		}
		public new global::java.lang.String PseudoSubject
		{
			get
			{
				return getPseudoSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPseudoSubject7469;
		public virtual global::java.lang.String getPseudoSubject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getPseudoSubject7469)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPseudoSubject7469)) as java.lang.String;
		}
		public new long TimestampMillis
		{
			get
			{
				return getTimestampMillis();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimestampMillis7470;
		public virtual long getTimestampMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.telephony.SmsMessage._getTimestampMillis7470);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTimestampMillis7470);
		}
		internal static global::MonoJavaBridge.MethodId _isEmail7471;
		public virtual bool isEmail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isEmail7471);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isEmail7471);
		}
		public new global::java.lang.String EmailBody
		{
			get
			{
				return getEmailBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailBody7472;
		public virtual global::java.lang.String getEmailBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getEmailBody7472)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailBody7472)) as java.lang.String;
		}
		public new global::java.lang.String EmailFrom
		{
			get
			{
				return getEmailFrom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailFrom7473;
		public virtual global::java.lang.String getEmailFrom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getEmailFrom7473)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailFrom7473)) as java.lang.String;
		}
		public new int ProtocolIdentifier
		{
			get
			{
				return getProtocolIdentifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolIdentifier7474;
		public virtual int getProtocolIdentifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getProtocolIdentifier7474);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getProtocolIdentifier7474);
		}
		internal static global::MonoJavaBridge.MethodId _isReplace7475;
		public virtual bool isReplace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isReplace7475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplace7475);
		}
		internal static global::MonoJavaBridge.MethodId _isCphsMwiMessage7476;
		public virtual bool isCphsMwiMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isCphsMwiMessage7476);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isCphsMwiMessage7476);
		}
		internal static global::MonoJavaBridge.MethodId _isMWIClearMessage7477;
		public virtual bool isMWIClearMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isMWIClearMessage7477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWIClearMessage7477);
		}
		internal static global::MonoJavaBridge.MethodId _isMWISetMessage7478;
		public virtual bool isMWISetMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isMWISetMessage7478);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWISetMessage7478);
		}
		internal static global::MonoJavaBridge.MethodId _isMwiDontStore7479;
		public virtual bool isMwiDontStore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isMwiDontStore7479);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMwiDontStore7479);
		}
		public new byte[] Pdu
		{
			get
			{
				return getPdu();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPdu7480;
		public virtual byte[] getPdu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getPdu7480)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPdu7480)) as byte[];
		}
		public new int StatusOnSim
		{
			get
			{
				return getStatusOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusOnSim7481;
		public virtual int getStatusOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getStatusOnSim7481);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnSim7481);
		}
		public new int StatusOnIcc
		{
			get
			{
				return getStatusOnIcc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusOnIcc7482;
		public virtual int getStatusOnIcc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getStatusOnIcc7482);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnIcc7482);
		}
		public new int IndexOnSim
		{
			get
			{
				return getIndexOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexOnSim7483;
		public virtual int getIndexOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getIndexOnSim7483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnSim7483);
		}
		public new int IndexOnIcc
		{
			get
			{
				return getIndexOnIcc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexOnIcc7484;
		public virtual int getIndexOnIcc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getIndexOnIcc7484);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnIcc7484);
		}
		internal static global::MonoJavaBridge.MethodId _isStatusReportMessage7485;
		public virtual bool isStatusReportMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isStatusReportMessage7485);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isStatusReportMessage7485);
		}
		internal static global::MonoJavaBridge.MethodId _isReplyPathPresent7486;
		public virtual bool isReplyPathPresent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isReplyPathPresent7486);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplyPathPresent7486);
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
		public static int MAX_USER_DATA_BYTES_WITH_HEADER
		{
			get
			{
				return 134;
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
			global::android.telephony.SmsMessage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SmsMessage"));
			global::android.telephony.SmsMessage._getUserData7455 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.SmsMessage._getStatus7456 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.SmsMessage._createFromPdu7457 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/SmsMessage;");
			global::android.telephony.SmsMessage._getTPLayerLengthForPDU7458 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.SmsMessage._calculateLength7459 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.SmsMessage._calculateLength7460 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.SmsMessage._getSubmitPdu7461 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu;");
			global::android.telephony.SmsMessage._getSubmitPdu7462 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/SmsMessage$SubmitPdu;");
			global::android.telephony.SmsMessage._getServiceCenterAddress7463 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getOriginatingAddress7464 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getDisplayOriginatingAddress7465 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getMessageBody7466 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getMessageClass7467 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;");
			global::android.telephony.SmsMessage._getDisplayMessageBody7468 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getPseudoSubject7469 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getTimestampMillis7470 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.SmsMessage._isEmail7471 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.SmsMessage._getEmailBody7472 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getEmailFrom7473 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getProtocolIdentifier7474 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.SmsMessage._isReplace7475 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.SmsMessage._isCphsMwiMessage7476 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.SmsMessage._isMWIClearMessage7477 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.SmsMessage._isMWISetMessage7478 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.SmsMessage._isMwiDontStore7479 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.SmsMessage._getPdu7480 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.SmsMessage._getStatusOnSim7481 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.SmsMessage._getStatusOnIcc7482 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getStatusOnIcc", "()I");
			global::android.telephony.SmsMessage._getIndexOnSim7483 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.SmsMessage._getIndexOnIcc7484 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getIndexOnIcc", "()I");
			global::android.telephony.SmsMessage._isStatusReportMessage7485 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.SmsMessage._isReplyPathPresent7486 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
		}
	}
}
