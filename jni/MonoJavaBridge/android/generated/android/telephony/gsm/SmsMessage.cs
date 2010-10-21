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
			internal static global::MonoJavaBridge.MethodId _values12004;
			public static global::android.telephony.gsm.SmsMessage.MessageClass[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._values12004)) as android.telephony.gsm.SmsMessage.MessageClass[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf12005;
			public static global::android.telephony.gsm.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._valueOf12005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage.MessageClass;
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_012006;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_012006)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_112007;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_112007)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_212008;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_212008)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_312009;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_312009)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN12010;
			public static global::android.telephony.gsm.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _UNKNOWN12010)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.MessageClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$MessageClass"));
				global::android.telephony.gsm.SmsMessage.MessageClass._values12004 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/gsm/SmsMessage/MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._valueOf12005 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_012006 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_0", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_112007 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_1", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_212008 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_2", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_312009 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_3", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._UNKNOWN12010 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "UNKNOWN", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
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
			internal static global::MonoJavaBridge.MethodId _toString12011;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString12011)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString12011)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _SubmitPdu12012;
			public SubmitPdu()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu12012);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _encodedScAddress12013;
			public byte[] encodedScAddress
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedScAddress12013)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _encodedMessage12014;
			public byte[] encodedMessage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedMessage12014)) as byte[];
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$SubmitPdu"));
				global::android.telephony.gsm.SmsMessage.SubmitPdu._toString12011 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu12012 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "<init>", "()V");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._encodedScAddress12013 = @__env.GetFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "encodedScAddress", "[B");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._encodedMessage12014 = @__env.GetFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "encodedMessage", "[B");
			}
		}
		public new byte[] UserData
		{
			get
			{
				return getUserData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserData12015;
		public virtual byte[] getUserData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getUserData12015)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getUserData12015)) as byte[];
		}
		public new int Status
		{
			get
			{
				return getStatus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatus12016;
		public virtual int getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getStatus12016);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatus12016);
		}
		internal static global::MonoJavaBridge.MethodId _createFromPdu12017;
		public static global::android.telephony.gsm.SmsMessage createFromPdu(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._createFromPdu12017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage;
		}
		internal static global::MonoJavaBridge.MethodId _getTPLayerLengthForPDU12018;
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU12018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength12019;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength12019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength12020;
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength12020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu12021;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu12021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu12022;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu12022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		public new global::java.lang.String ServiceCenterAddress
		{
			get
			{
				return getServiceCenterAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceCenterAddress12023;
		public virtual global::java.lang.String getServiceCenterAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress12023)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress12023)) as java.lang.String;
		}
		public new global::java.lang.String OriginatingAddress
		{
			get
			{
				return getOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginatingAddress12024;
		public virtual global::java.lang.String getOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getOriginatingAddress12024)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getOriginatingAddress12024)) as java.lang.String;
		}
		public new global::java.lang.String DisplayOriginatingAddress
		{
			get
			{
				return getDisplayOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayOriginatingAddress12025;
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress12025)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress12025)) as java.lang.String;
		}
		public new global::java.lang.String MessageBody
		{
			get
			{
				return getMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageBody12026;
		public virtual global::java.lang.String getMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getMessageBody12026)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageBody12026)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMessageClass12027;
		public virtual global::android.telephony.gsm.SmsMessage.MessageClass getMessageClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getMessageClass12027)) as android.telephony.gsm.SmsMessage.MessageClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageClass12027)) as android.telephony.gsm.SmsMessage.MessageClass;
		}
		public new global::java.lang.String DisplayMessageBody
		{
			get
			{
				return getDisplayMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMessageBody12028;
		public virtual global::java.lang.String getDisplayMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody12028)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody12028)) as java.lang.String;
		}
		public new global::java.lang.String PseudoSubject
		{
			get
			{
				return getPseudoSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPseudoSubject12029;
		public virtual global::java.lang.String getPseudoSubject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getPseudoSubject12029)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPseudoSubject12029)) as java.lang.String;
		}
		public new long TimestampMillis
		{
			get
			{
				return getTimestampMillis();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimestampMillis12030;
		public virtual long getTimestampMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getTimestampMillis12030);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTimestampMillis12030);
		}
		internal static global::MonoJavaBridge.MethodId _isEmail12031;
		public virtual bool isEmail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isEmail12031);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isEmail12031);
		}
		public new global::java.lang.String EmailBody
		{
			get
			{
				return getEmailBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailBody12032;
		public virtual global::java.lang.String getEmailBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getEmailBody12032)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailBody12032)) as java.lang.String;
		}
		public new global::java.lang.String EmailFrom
		{
			get
			{
				return getEmailFrom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailFrom12033;
		public virtual global::java.lang.String getEmailFrom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getEmailFrom12033)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailFrom12033)) as java.lang.String;
		}
		public new int ProtocolIdentifier
		{
			get
			{
				return getProtocolIdentifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolIdentifier12034;
		public virtual int getProtocolIdentifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier12034);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier12034);
		}
		internal static global::MonoJavaBridge.MethodId _isReplace12035;
		public virtual bool isReplace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isReplace12035);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplace12035);
		}
		internal static global::MonoJavaBridge.MethodId _isCphsMwiMessage12036;
		public virtual bool isCphsMwiMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage12036);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage12036);
		}
		internal static global::MonoJavaBridge.MethodId _isMWIClearMessage12037;
		public virtual bool isMWIClearMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMWIClearMessage12037);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWIClearMessage12037);
		}
		internal static global::MonoJavaBridge.MethodId _isMWISetMessage12038;
		public virtual bool isMWISetMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMWISetMessage12038);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWISetMessage12038);
		}
		internal static global::MonoJavaBridge.MethodId _isMwiDontStore12039;
		public virtual bool isMwiDontStore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMwiDontStore12039);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMwiDontStore12039);
		}
		public new byte[] Pdu
		{
			get
			{
				return getPdu();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPdu12040;
		public virtual byte[] getPdu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getPdu12040)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPdu12040)) as byte[];
		}
		public new int StatusOnSim
		{
			get
			{
				return getStatusOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusOnSim12041;
		public virtual int getStatusOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getStatusOnSim12041);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatusOnSim12041);
		}
		public new int IndexOnSim
		{
			get
			{
				return getIndexOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexOnSim12042;
		public virtual int getIndexOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getIndexOnSim12042);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getIndexOnSim12042);
		}
		internal static global::MonoJavaBridge.MethodId _isStatusReportMessage12043;
		public virtual bool isStatusReportMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isStatusReportMessage12043);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isStatusReportMessage12043);
		}
		internal static global::MonoJavaBridge.MethodId _isReplyPathPresent12044;
		public virtual bool isReplyPathPresent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isReplyPathPresent12044);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplyPathPresent12044);
		}
		internal static global::MonoJavaBridge.MethodId _SmsMessage12045;
		public SmsMessage()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._SmsMessage12045);
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
			global::android.telephony.gsm.SmsMessage._getUserData12015 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatus12016 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.gsm.SmsMessage._createFromPdu12017 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;");
			global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU12018 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.gsm.SmsMessage._calculateLength12019 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.gsm.SmsMessage._calculateLength12020 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu12021 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu12022 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getServiceCenterAddress12023 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getOriginatingAddress12024 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress12025 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageBody12026 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageClass12027 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;");
			global::android.telephony.gsm.SmsMessage._getDisplayMessageBody12028 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getPseudoSubject12029 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getTimestampMillis12030 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.gsm.SmsMessage._isEmail12031 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.gsm.SmsMessage._getEmailBody12032 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getEmailFrom12033 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getProtocolIdentifier12034 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.gsm.SmsMessage._isReplace12035 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.gsm.SmsMessage._isCphsMwiMessage12036 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWIClearMessage12037 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWISetMessage12038 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMwiDontStore12039 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.gsm.SmsMessage._getPdu12040 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatusOnSim12041 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._getIndexOnSim12042 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._isStatusReportMessage12043 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isReplyPathPresent12044 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
			global::android.telephony.gsm.SmsMessage._SmsMessage12045 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "<init>", "()V");
		}
	}
}
