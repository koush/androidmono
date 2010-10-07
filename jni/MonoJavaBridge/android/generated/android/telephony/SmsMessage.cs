namespace android.telephony
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SmsMessage : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SmsMessage()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.SmsMessage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.SmsMessage(@__env);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.SmsMessage.MessageClass), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.telephony.SmsMessage.MessageClass(@__env);
				}
			}
			internal MessageClass(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values7165;
			public static global::android.telephony.SmsMessage.MessageClass[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._values7165));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf7166;
			public static global::android.telephony.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._valueOf7166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_07167;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_17168;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_27169;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_37170;
			public static global::android.telephony.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN7171;
			public static global::android.telephony.SmsMessage.MessageClass UNKNOWN
			{
				get
				{
					return default(global::android.telephony.SmsMessage.MessageClass);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.telephony.SmsMessage.MessageClass.staticClass = @__class;
				global::android.telephony.SmsMessage.MessageClass._values7165 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/SmsMessage/MessageClass;");
				global::android.telephony.SmsMessage.MessageClass._valueOf7166 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class SubmitPdu : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static SubmitPdu()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.SmsMessage.SubmitPdu), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.telephony.SmsMessage.SubmitPdu(@__env);
				}
			}
			protected SubmitPdu(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString7172;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage.SubmitPdu._toString7172));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.SubmitPdu.staticClass, global::android.telephony.SmsMessage.SubmitPdu._toString7172));
			}
			internal static global::net.sf.jni4net.jni.FieldId _encodedScAddress7173;
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
			internal static global::net.sf.jni4net.jni.FieldId _encodedMessage7174;
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
				global::android.telephony.SmsMessage.SubmitPdu.staticClass = @__class;
				global::android.telephony.SmsMessage.SubmitPdu._toString7172 = @__env.GetMethodID(global::android.telephony.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserData7175;
		public virtual byte[] getUserData() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getUserData7175));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getUserData7175));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatus7176;
		public virtual int getStatus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getStatus7176);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatus7176);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromPdu7177;
		public static global::android.telephony.SmsMessage createFromPdu(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._createFromPdu7177, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTPLayerLengthForPDU7178;
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTPLayerLengthForPDU7178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength7179;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength7179, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength7180;
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength7180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu7181;
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu7181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu7182;
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu7182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServiceCenterAddress7183;
		public virtual global::java.lang.String getServiceCenterAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getServiceCenterAddress7183));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getServiceCenterAddress7183));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOriginatingAddress7184;
		public virtual global::java.lang.String getOriginatingAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getOriginatingAddress7184));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getOriginatingAddress7184));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayOriginatingAddress7185;
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getDisplayOriginatingAddress7185));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayOriginatingAddress7185));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMessageBody7186;
		public virtual global::java.lang.String getMessageBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getMessageBody7186));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageBody7186));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMessageClass7187;
		public virtual global::android.telephony.SmsMessage.MessageClass getMessageClass() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getMessageClass7187));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageClass7187));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMessageBody7188;
		public virtual global::java.lang.String getDisplayMessageBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getDisplayMessageBody7188));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayMessageBody7188));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPseudoSubject7189;
		public virtual global::java.lang.String getPseudoSubject() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getPseudoSubject7189));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPseudoSubject7189));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimestampMillis7190;
		public virtual long getTimestampMillis() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.telephony.SmsMessage._getTimestampMillis7190);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTimestampMillis7190);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmail7191;
		public virtual bool isEmail() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isEmail7191);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isEmail7191);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmailBody7192;
		public virtual global::java.lang.String getEmailBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getEmailBody7192));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailBody7192));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmailFrom7193;
		public virtual global::java.lang.String getEmailFrom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getEmailFrom7193));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailFrom7193));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolIdentifier7194;
		public virtual int getProtocolIdentifier() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getProtocolIdentifier7194);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getProtocolIdentifier7194);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReplace7195;
		public virtual bool isReplace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isReplace7195);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplace7195);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCphsMwiMessage7196;
		public virtual bool isCphsMwiMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isCphsMwiMessage7196);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isCphsMwiMessage7196);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMWIClearMessage7197;
		public virtual bool isMWIClearMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isMWIClearMessage7197);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWIClearMessage7197);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMWISetMessage7198;
		public virtual bool isMWISetMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isMWISetMessage7198);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWISetMessage7198);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMwiDontStore7199;
		public virtual bool isMwiDontStore() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isMwiDontStore7199);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMwiDontStore7199);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPdu7200;
		public virtual byte[] getPdu() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getPdu7200));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPdu7200));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnSim7201;
		public virtual int getStatusOnSim() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getStatusOnSim7201);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnSim7201);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnIcc7202;
		public virtual int getStatusOnIcc() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getStatusOnIcc7202);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnIcc7202);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnSim7203;
		public virtual int getIndexOnSim() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getIndexOnSim7203);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnSim7203);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnIcc7204;
		public virtual int getIndexOnIcc() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getIndexOnIcc7204);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnIcc7204);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStatusReportMessage7205;
		public virtual bool isStatusReportMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isStatusReportMessage7205);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isStatusReportMessage7205);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReplyPathPresent7206;
		public virtual bool isReplyPathPresent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isReplyPathPresent7206);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplyPathPresent7206);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.SmsMessage.staticClass = @__class;
			global::android.telephony.SmsMessage._getUserData7175 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.SmsMessage._getStatus7176 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.SmsMessage._createFromPdu7177 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/SmsMessage;");
			global::android.telephony.SmsMessage._getTPLayerLengthForPDU7178 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.SmsMessage._calculateLength7179 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.SmsMessage._calculateLength7180 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.SmsMessage._getSubmitPdu7181 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu;");
			global::android.telephony.SmsMessage._getSubmitPdu7182 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/SmsMessage$SubmitPdu;");
			global::android.telephony.SmsMessage._getServiceCenterAddress7183 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getOriginatingAddress7184 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getDisplayOriginatingAddress7185 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getMessageBody7186 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getMessageClass7187 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;");
			global::android.telephony.SmsMessage._getDisplayMessageBody7188 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getPseudoSubject7189 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getTimestampMillis7190 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.SmsMessage._isEmail7191 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.SmsMessage._getEmailBody7192 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getEmailFrom7193 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.SmsMessage._getProtocolIdentifier7194 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.SmsMessage._isReplace7195 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.SmsMessage._isCphsMwiMessage7196 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.SmsMessage._isMWIClearMessage7197 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.SmsMessage._isMWISetMessage7198 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.SmsMessage._isMwiDontStore7199 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.SmsMessage._getPdu7200 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.SmsMessage._getStatusOnSim7201 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.SmsMessage._getStatusOnIcc7202 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatusOnIcc", "()I");
			global::android.telephony.SmsMessage._getIndexOnSim7203 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.SmsMessage._getIndexOnIcc7204 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getIndexOnIcc", "()I");
			global::android.telephony.SmsMessage._isStatusReportMessage7205 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.SmsMessage._isReplyPathPresent7206 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
		}
	}
}
