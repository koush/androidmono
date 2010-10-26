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
			internal static global::MonoJavaBridge.MethodId _values11910;
			public static global::android.telephony.SmsMessage.MessageClass[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.telephony.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._values11910)) as android.telephony.SmsMessage.MessageClass[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf11911;
			public static global::android.telephony.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._valueOf11911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.SmsMessage.MessageClass;
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_011912;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.SmsMessage.MessageClass.staticClass, _CLASS_011912)) as android.telephony.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_111913;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.SmsMessage.MessageClass.staticClass, _CLASS_111913)) as android.telephony.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_211914;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.SmsMessage.MessageClass.staticClass, _CLASS_211914)) as android.telephony.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLASS_311915;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.SmsMessage.MessageClass.staticClass, _CLASS_311915)) as android.telephony.SmsMessage.MessageClass;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN11916;
			public static global::android.telephony.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.GetStaticObjectField(global::android.telephony.SmsMessage.MessageClass.staticClass, _UNKNOWN11916)) as android.telephony.SmsMessage.MessageClass;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.SmsMessage.MessageClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SmsMessage$MessageClass"));
				global::android.telephony.SmsMessage.MessageClass._values11910 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/SmsMessage/MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._valueOf11911 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._CLASS_011912 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "CLASS_0", "Landroid/telephony/SmsMessage$MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._CLASS_111913 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "CLASS_1", "Landroid/telephony/SmsMessage$MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._CLASS_211914 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "CLASS_2", "Landroid/telephony/SmsMessage$MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._CLASS_311915 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "CLASS_3", "Landroid/telephony/SmsMessage$MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._UNKNOWN11916 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.SmsMessage.MessageClass.staticClass, "UNKNOWN", "Landroid/telephony/SmsMessage$MessageClass;");
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
			internal static global::MonoJavaBridge.MethodId _toString11917;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.SubmitPdu._toString11917)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.SubmitPdu.staticClass, global::android.telephony.SmsMessage.SubmitPdu._toString11917)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.FieldId _encodedScAddress11918;
			public byte[] encodedScAddress
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedScAddress11918)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _encodedMessage11919;
			public byte[] encodedMessage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _encodedMessage11919)) as byte[];
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.telephony.SmsMessage.SubmitPdu.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SmsMessage$SubmitPdu"));
				global::android.telephony.SmsMessage.SubmitPdu._toString11917 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
				global::android.telephony.SmsMessage.SubmitPdu._encodedScAddress11918 = @__env.GetFieldIDNoThrow(global::android.telephony.SmsMessage.SubmitPdu.staticClass, "encodedScAddress", "[B");
				global::android.telephony.SmsMessage.SubmitPdu._encodedMessage11919 = @__env.GetFieldIDNoThrow(global::android.telephony.SmsMessage.SubmitPdu.staticClass, "encodedMessage", "[B");
			}
		}
		public new byte[] UserData
		{
			get
			{
				return getUserData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserData11920;
		public virtual byte[] getUserData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getUserData11920)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getUserData11920)) as byte[];
		}
		public new int Status
		{
			get
			{
				return getStatus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatus11921;
		public virtual int getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getStatus11921);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatus11921);
		}
		internal static global::MonoJavaBridge.MethodId _createFromPdu11922;
		public static global::android.telephony.SmsMessage createFromPdu(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._createFromPdu11922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.telephony.SmsMessage;
		}
		internal static global::MonoJavaBridge.MethodId _getTPLayerLengthForPDU11923;
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTPLayerLengthForPDU11923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength11924;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength11924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		public static int[] calculateLength(string arg0, bool arg1)
		{
			return calculateLength((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _calculateLength11925;
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength11925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu11926;
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu11926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.telephony.SmsMessage.SubmitPdu;
		}
		internal static global::MonoJavaBridge.MethodId _getSubmitPdu11927;
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu11927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.telephony.SmsMessage.SubmitPdu;
		}
		public new global::java.lang.String ServiceCenterAddress
		{
			get
			{
				return getServiceCenterAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceCenterAddress11928;
		public virtual global::java.lang.String getServiceCenterAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getServiceCenterAddress11928)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getServiceCenterAddress11928)) as java.lang.String;
		}
		public new global::java.lang.String OriginatingAddress
		{
			get
			{
				return getOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginatingAddress11929;
		public virtual global::java.lang.String getOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getOriginatingAddress11929)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getOriginatingAddress11929)) as java.lang.String;
		}
		public new global::java.lang.String DisplayOriginatingAddress
		{
			get
			{
				return getDisplayOriginatingAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayOriginatingAddress11930;
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getDisplayOriginatingAddress11930)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayOriginatingAddress11930)) as java.lang.String;
		}
		public new global::java.lang.String MessageBody
		{
			get
			{
				return getMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageBody11931;
		public virtual global::java.lang.String getMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getMessageBody11931)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageBody11931)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMessageClass11932;
		public virtual global::android.telephony.SmsMessage.MessageClass getMessageClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getMessageClass11932)) as android.telephony.SmsMessage.MessageClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.SmsMessage.MessageClass>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageClass11932)) as android.telephony.SmsMessage.MessageClass;
		}
		public new global::java.lang.String DisplayMessageBody
		{
			get
			{
				return getDisplayMessageBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayMessageBody11933;
		public virtual global::java.lang.String getDisplayMessageBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getDisplayMessageBody11933)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayMessageBody11933)) as java.lang.String;
		}
		public new global::java.lang.String PseudoSubject
		{
			get
			{
				return getPseudoSubject();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPseudoSubject11934;
		public virtual global::java.lang.String getPseudoSubject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getPseudoSubject11934)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPseudoSubject11934)) as java.lang.String;
		}
		public new long TimestampMillis
		{
			get
			{
				return getTimestampMillis();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimestampMillis11935;
		public virtual long getTimestampMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.telephony.SmsMessage._getTimestampMillis11935);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTimestampMillis11935);
		}
		internal static global::MonoJavaBridge.MethodId _isEmail11936;
		public virtual bool isEmail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isEmail11936);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isEmail11936);
		}
		public new global::java.lang.String EmailBody
		{
			get
			{
				return getEmailBody();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailBody11937;
		public virtual global::java.lang.String getEmailBody() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getEmailBody11937)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailBody11937)) as java.lang.String;
		}
		public new global::java.lang.String EmailFrom
		{
			get
			{
				return getEmailFrom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEmailFrom11938;
		public virtual global::java.lang.String getEmailFrom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getEmailFrom11938)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailFrom11938)) as java.lang.String;
		}
		public new int ProtocolIdentifier
		{
			get
			{
				return getProtocolIdentifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolIdentifier11939;
		public virtual int getProtocolIdentifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getProtocolIdentifier11939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getProtocolIdentifier11939);
		}
		internal static global::MonoJavaBridge.MethodId _isReplace11940;
		public virtual bool isReplace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isReplace11940);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplace11940);
		}
		internal static global::MonoJavaBridge.MethodId _isCphsMwiMessage11941;
		public virtual bool isCphsMwiMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isCphsMwiMessage11941);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isCphsMwiMessage11941);
		}
		internal static global::MonoJavaBridge.MethodId _isMWIClearMessage11942;
		public virtual bool isMWIClearMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isMWIClearMessage11942);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWIClearMessage11942);
		}
		internal static global::MonoJavaBridge.MethodId _isMWISetMessage11943;
		public virtual bool isMWISetMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isMWISetMessage11943);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWISetMessage11943);
		}
		internal static global::MonoJavaBridge.MethodId _isMwiDontStore11944;
		public virtual bool isMwiDontStore() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isMwiDontStore11944);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMwiDontStore11944);
		}
		public new byte[] Pdu
		{
			get
			{
				return getPdu();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPdu11945;
		public virtual byte[] getPdu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage._getPdu11945)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPdu11945)) as byte[];
		}
		public new int StatusOnSim
		{
			get
			{
				return getStatusOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusOnSim11946;
		public virtual int getStatusOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getStatusOnSim11946);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnSim11946);
		}
		public new int StatusOnIcc
		{
			get
			{
				return getStatusOnIcc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusOnIcc11947;
		public virtual int getStatusOnIcc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getStatusOnIcc11947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnIcc11947);
		}
		public new int IndexOnSim
		{
			get
			{
				return getIndexOnSim();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexOnSim11948;
		public virtual int getIndexOnSim() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getIndexOnSim11948);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnSim11948);
		}
		public new int IndexOnIcc
		{
			get
			{
				return getIndexOnIcc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexOnIcc11949;
		public virtual int getIndexOnIcc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SmsMessage._getIndexOnIcc11949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnIcc11949);
		}
		internal static global::MonoJavaBridge.MethodId _isStatusReportMessage11950;
		public virtual bool isStatusReportMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isStatusReportMessage11950);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isStatusReportMessage11950);
		}
		internal static global::MonoJavaBridge.MethodId _isReplyPathPresent11951;
		public virtual bool isReplyPathPresent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage._isReplyPathPresent11951);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplyPathPresent11951);
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
			global::android.telephony.SmsMessage._getUserData11920 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.SmsMessage._getStatus11921 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.SmsMessage._createFromPdu11922 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/SmsMessage;");
			global::android.telephony.SmsMessage._getTPLayerLengthForPDU11923 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.SmsMessage._calculateLength11924 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.SmsMessage._calculateLength11925 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.SmsMessage._getSubmitPdu11926 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu;");
			global::android.telephony.SmsMessage._getSubmitPdu11927 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/SmsMessage$SubmitPdu;");
			global::android.telephony.SmsMessage._getServiceCenterAddress11928 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getOriginatingAddress11929 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getDisplayOriginatingAddress11930 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getMessageBody11931 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getMessageClass11932 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;");
			global::android.telephony.SmsMessage._getDisplayMessageBody11933 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getPseudoSubject11934 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getTimestampMillis11935 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.SmsMessage._isEmail11936 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.SmsMessage._getEmailBody11937 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getEmailFrom11938 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getProtocolIdentifier11939 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.SmsMessage._isReplace11940 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.SmsMessage._isCphsMwiMessage11941 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.SmsMessage._isMWIClearMessage11942 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.SmsMessage._isMWISetMessage11943 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.SmsMessage._isMwiDontStore11944 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.SmsMessage._getPdu11945 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.SmsMessage._getStatusOnSim11946 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.SmsMessage._getStatusOnIcc11947 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getStatusOnIcc", "()I");
			global::android.telephony.SmsMessage._getIndexOnSim11948 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.SmsMessage._getIndexOnIcc11949 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "getIndexOnIcc", "()I");
			global::android.telephony.SmsMessage._isStatusReportMessage11950 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.SmsMessage._isReplyPathPresent11951 = @__env.GetMethodIDNoThrow(global::android.telephony.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
		}
	}
}
