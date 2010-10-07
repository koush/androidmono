namespace android.telephony.gsm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SmsMessage : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SmsMessage()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.gsm.SmsMessage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.gsm.SmsMessage(@__env);
			}
		}
		protected SmsMessage(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class MessageClass : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static MessageClass()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.gsm.SmsMessage.MessageClass), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.telephony.gsm.SmsMessage.MessageClass(@__env);
				}
			}
			internal MessageClass(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values7263;
			public static global::android.telephony.gsm.SmsMessage.MessageClass[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._values7263));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf7264;
			public static global::android.telephony.gsm.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._valueOf7264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_07265;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_17266;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_27267;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_37268;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN7269;
			public static global::android.telephony.gsm.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.telephony.gsm.SmsMessage.MessageClass.staticClass = @__class;
				global::android.telephony.gsm.SmsMessage.MessageClass._values7263 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/gsm/SmsMessage/MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._valueOf7264 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class SubmitPdu : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static SubmitPdu()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.gsm.SmsMessage.SubmitPdu), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.telephony.gsm.SmsMessage.SubmitPdu(@__env);
				}
			}
			protected SubmitPdu(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString7270;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString7270));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString7270));
			}
			internal static global::net.sf.jni4net.jni.MethodId _SubmitPdu7271;
			public SubmitPdu()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu7271, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _encodedScAddress7272;
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
			internal static global::net.sf.jni4net.jni.FieldId _encodedMessage7273;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass = @__class;
				global::android.telephony.gsm.SmsMessage.SubmitPdu._toString7270 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu7271 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserData7274;
		public virtual byte[] getUserData() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getUserData7274));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getUserData7274));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatus7275;
		public virtual int getStatus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getStatus7275);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatus7275);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromPdu7276;
		public static global::android.telephony.gsm.SmsMessage createFromPdu(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._createFromPdu7276, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTPLayerLengthForPDU7277;
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU7277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength7278;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength7278, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength7279;
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength7279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu7280;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu7280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu7281;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu7281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServiceCenterAddress7282;
		public virtual global::java.lang.String getServiceCenterAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress7282));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress7282));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOriginatingAddress7283;
		public virtual global::java.lang.String getOriginatingAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getOriginatingAddress7283));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getOriginatingAddress7283));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayOriginatingAddress7284;
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress7284));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress7284));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMessageBody7285;
		public virtual global::java.lang.String getMessageBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getMessageBody7285));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageBody7285));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMessageClass7286;
		public virtual global::android.telephony.gsm.SmsMessage.MessageClass getMessageClass() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getMessageClass7286));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageClass7286));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMessageBody7287;
		public virtual global::java.lang.String getDisplayMessageBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody7287));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody7287));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPseudoSubject7288;
		public virtual global::java.lang.String getPseudoSubject() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getPseudoSubject7288));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPseudoSubject7288));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimestampMillis7289;
		public virtual long getTimestampMillis() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.telephony.gsm.SmsMessage._getTimestampMillis7289);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTimestampMillis7289);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmail7290;
		public virtual bool isEmail() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isEmail7290);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isEmail7290);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmailBody7291;
		public virtual global::java.lang.String getEmailBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getEmailBody7291));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailBody7291));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmailFrom7292;
		public virtual global::java.lang.String getEmailFrom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getEmailFrom7292));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailFrom7292));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolIdentifier7293;
		public virtual int getProtocolIdentifier() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier7293);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier7293);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReplace7294;
		public virtual bool isReplace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isReplace7294);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplace7294);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCphsMwiMessage7295;
		public virtual bool isCphsMwiMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage7295);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage7295);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMWIClearMessage7296;
		public virtual bool isMWIClearMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isMWIClearMessage7296);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWIClearMessage7296);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMWISetMessage7297;
		public virtual bool isMWISetMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isMWISetMessage7297);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWISetMessage7297);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMwiDontStore7298;
		public virtual bool isMwiDontStore() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isMwiDontStore7298);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMwiDontStore7298);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPdu7299;
		public virtual byte[] getPdu() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getPdu7299));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPdu7299));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnSim7300;
		public virtual int getStatusOnSim() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getStatusOnSim7300);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatusOnSim7300);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnSim7301;
		public virtual int getIndexOnSim() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getIndexOnSim7301);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getIndexOnSim7301);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStatusReportMessage7302;
		public virtual bool isStatusReportMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isStatusReportMessage7302);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isStatusReportMessage7302);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReplyPathPresent7303;
		public virtual bool isReplyPathPresent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isReplyPathPresent7303);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplyPathPresent7303);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SmsMessage7304;
		public SmsMessage()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._SmsMessage7304, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.gsm.SmsMessage.staticClass = @__class;
			global::android.telephony.gsm.SmsMessage._getUserData7274 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatus7275 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.gsm.SmsMessage._createFromPdu7276 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;");
			global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU7277 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.gsm.SmsMessage._calculateLength7278 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.gsm.SmsMessage._calculateLength7279 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu7280 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu7281 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getServiceCenterAddress7282 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getOriginatingAddress7283 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress7284 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageBody7285 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageClass7286 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;");
			global::android.telephony.gsm.SmsMessage._getDisplayMessageBody7287 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getPseudoSubject7288 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getTimestampMillis7289 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.gsm.SmsMessage._isEmail7290 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.gsm.SmsMessage._getEmailBody7291 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getEmailFrom7292 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getProtocolIdentifier7293 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.gsm.SmsMessage._isReplace7294 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.gsm.SmsMessage._isCphsMwiMessage7295 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWIClearMessage7296 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWISetMessage7297 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMwiDontStore7298 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.gsm.SmsMessage._getPdu7299 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatusOnSim7300 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._getIndexOnSim7301 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._isStatusReportMessage7302 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isReplyPathPresent7303 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
			global::android.telephony.gsm.SmsMessage._SmsMessage7304 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "<init>", "()V");
		}
	}
}
