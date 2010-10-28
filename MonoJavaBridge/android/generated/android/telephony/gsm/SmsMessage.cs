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
			internal static global::MonoJavaBridge.MethodId _values12061;
			public static global::android.telephony.gsm.SmsMessage.MessageClass[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._values12061)) as android.telephony.gsm.SmsMessage.MessageClass[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf12062;
			public static global::android.telephony.gsm.SmsMessage.MessageClass valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._valueOf12062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage.MessageClass;
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_012063;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_012063)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_112064;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_112064)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_212065;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_212065)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_312066;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _CLASS_312066)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN12067;
			public static global::android.telephony.gsm.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, _UNKNOWN12067)) as android.telephony.gsm.SmsMessage.MessageClass;
				}
			}
			static MessageClass()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.MessageClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$MessageClass"));
				global::android.telephony.gsm.SmsMessage.MessageClass._values12061 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/gsm/SmsMessage/MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._valueOf12062 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_012063 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_0", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_112064 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_1", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_212065 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_2", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._CLASS_312066 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "CLASS_3", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._UNKNOWN12067 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "UNKNOWN", "Landroid/telephony/gsm/SmsMessage$MessageClass;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SubmitPdu : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SubmitPdu(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString12068;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString12068)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString12068)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _SubmitPdu12069;
			public SubmitPdu() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu12069);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _encodedScAddress12070;
			public byte[] encodedScAddress
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedScAddress12070)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _encodedMessage12071;
			public byte[] encodedMessage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedMessage12071)) as byte[];
				}
				set
				{
				}
			}
			static SubmitPdu()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsMessage$SubmitPdu"));
				global::android.telephony.gsm.SmsMessage.SubmitPdu._toString12068 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu12069 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "<init>", "()V");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._encodedScAddress12070 = @__env.GetFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "encodedScAddress", "[B");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._encodedMessage12071 = @__env.GetFieldIDNoThrow(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "encodedMessage", "[B");
			}
			internal static void InitJNI()
			{
			}
		}
		public new byte[] UserData
		{
			get
			{
				return getUserData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserData12072;
		public virtual byte[] getUserData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getUserData12072)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getUserData12072)) as byte[];
		}
		public new int Status
		{
			get
			{
				return getStatus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatus12073;
		public virtual int getStatus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getStatus12073);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatus12073);
		}
		internal static global::MonoJavaBridge.MethodId _createFromPdu12074;
		public static global::android.telephony.gsm.SmsMessage createFromPdu(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._createFromPdu12074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.gsm.SmsMessage;
		}
		internal static global::MonoJavaBridge.MethodId _getTPLayerLengthForPDU12075;
		public static int getTPLayerLengthForPDU(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU12075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength12076;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength12076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		public static int[] calculateLength(string arg0, bool arg1)
		{
			return calculateLength((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength12077;
		public static int[] calculateLength(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength12077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu12078;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu12078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu12079;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu12079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.telephony.gsm.SmsMessage.SubmitPdu;
		}
		public new global::java.lang.String ServiceCenterAddress
		{
			get
			{
				return getServiceCenterAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceCenterAddress12080;
		public virtual global::java.lang.String getServiceCenterAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress12080)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress12080)) as java.lang.String;
		}
		public new global::java.lang.String OriginatingAddress
		{
			get
			{
				return getOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginatingAddress12081;
		public virtual global::java.lang.String getOriginatingAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getOriginatingAddress12081)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getOriginatingAddress12081)) as java.lang.String;
		}
		public new global::java.lang.String DisplayOriginatingAddress
		{
			get
			{
				return getDisplayOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayOriginatingAddress12082;
		public virtual global::java.lang.String getDisplayOriginatingAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress12082)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress12082)) as java.lang.String;
		}
		public new global::java.lang.String MessageBody
		{
			get
			{
				return getMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageBody12083;
		public virtual global::java.lang.String getMessageBody()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getMessageBody12083)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageBody12083)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMessageClass12084;
		public virtual global::android.telephony.gsm.SmsMessage.MessageClass getMessageClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getMessageClass12084)) as android.telephony.gsm.SmsMessage.MessageClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsMessage.MessageClass>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageClass12084)) as android.telephony.gsm.SmsMessage.MessageClass;
		}
		public new global::java.lang.String DisplayMessageBody
		{
			get
			{
				return getDisplayMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMessageBody12085;
		public virtual global::java.lang.String getDisplayMessageBody()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody12085)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody12085)) as java.lang.String;
		}
		public new global::java.lang.String PseudoSubject
		{
			get
			{
				return getPseudoSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPseudoSubject12086;
		public virtual global::java.lang.String getPseudoSubject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getPseudoSubject12086)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPseudoSubject12086)) as java.lang.String;
		}
		public new long TimestampMillis
		{
			get
			{
				return getTimestampMillis();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimestampMillis12087;
		public virtual long getTimestampMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getTimestampMillis12087);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTimestampMillis12087);
		}
		internal static global::MonoJavaBridge.MethodId _isEmail12088;
		public virtual bool isEmail()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isEmail12088);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isEmail12088);
		}
		public new global::java.lang.String EmailBody
		{
			get
			{
				return getEmailBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailBody12089;
		public virtual global::java.lang.String getEmailBody()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getEmailBody12089)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailBody12089)) as java.lang.String;
		}
		public new global::java.lang.String EmailFrom
		{
			get
			{
				return getEmailFrom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailFrom12090;
		public virtual global::java.lang.String getEmailFrom()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getEmailFrom12090)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailFrom12090)) as java.lang.String;
		}
		public new int ProtocolIdentifier
		{
			get
			{
				return getProtocolIdentifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolIdentifier12091;
		public virtual int getProtocolIdentifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier12091);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier12091);
		}
		internal static global::MonoJavaBridge.MethodId _isReplace12092;
		public virtual bool isReplace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isReplace12092);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplace12092);
		}
		internal static global::MonoJavaBridge.MethodId _isCphsMwiMessage12093;
		public virtual bool isCphsMwiMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage12093);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage12093);
		}
		internal static global::MonoJavaBridge.MethodId _isMWIClearMessage12094;
		public virtual bool isMWIClearMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMWIClearMessage12094);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWIClearMessage12094);
		}
		internal static global::MonoJavaBridge.MethodId _isMWISetMessage12095;
		public virtual bool isMWISetMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMWISetMessage12095);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWISetMessage12095);
		}
		internal static global::MonoJavaBridge.MethodId _isMwiDontStore12096;
		public virtual bool isMwiDontStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isMwiDontStore12096);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMwiDontStore12096);
		}
		public new byte[] Pdu
		{
			get
			{
				return getPdu();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPdu12097;
		public virtual byte[] getPdu()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getPdu12097)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPdu12097)) as byte[];
		}
		public new int StatusOnSim
		{
			get
			{
				return getStatusOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusOnSim12098;
		public virtual int getStatusOnSim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getStatusOnSim12098);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatusOnSim12098);
		}
		public new int IndexOnSim
		{
			get
			{
				return getIndexOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexOnSim12099;
		public virtual int getIndexOnSim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._getIndexOnSim12099);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getIndexOnSim12099);
		}
		internal static global::MonoJavaBridge.MethodId _isStatusReportMessage12100;
		public virtual bool isStatusReportMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isStatusReportMessage12100);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isStatusReportMessage12100);
		}
		internal static global::MonoJavaBridge.MethodId _isReplyPathPresent12101;
		public virtual bool isReplyPathPresent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage._isReplyPathPresent12101);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplyPathPresent12101);
		}
		internal static global::MonoJavaBridge.MethodId _SmsMessage12102;
		public SmsMessage() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._SmsMessage12102);
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
			global::android.telephony.gsm.SmsMessage._getUserData12072 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatus12073 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.gsm.SmsMessage._createFromPdu12074 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;");
			global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU12075 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.gsm.SmsMessage._calculateLength12076 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.gsm.SmsMessage._calculateLength12077 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu12078 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu12079 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getServiceCenterAddress12080 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getOriginatingAddress12081 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress12082 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageBody12083 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageClass12084 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;");
			global::android.telephony.gsm.SmsMessage._getDisplayMessageBody12085 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getPseudoSubject12086 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getTimestampMillis12087 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.gsm.SmsMessage._isEmail12088 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.gsm.SmsMessage._getEmailBody12089 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getEmailFrom12090 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getProtocolIdentifier12091 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.gsm.SmsMessage._isReplace12092 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.gsm.SmsMessage._isCphsMwiMessage12093 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWIClearMessage12094 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWISetMessage12095 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMwiDontStore12096 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.gsm.SmsMessage._getPdu12097 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatusOnSim12098 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._getIndexOnSim12099 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._isStatusReportMessage12100 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isReplyPathPresent12101 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
			global::android.telephony.gsm.SmsMessage._SmsMessage12102 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.SmsMessage.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
