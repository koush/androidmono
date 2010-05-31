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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf6639;
			public static global::android.telephony.gsm.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._valueOf6639, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _values6640;
			public static global::android.telephony.gsm.SmsMessage.MessageClass[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.MessageClass.staticClass, global::android.telephony.gsm.SmsMessage.MessageClass._values6640));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_06641;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_0
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_16642;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_1
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_26643;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_2
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_36644;
			public static global::android.telephony.gsm.SmsMessage.MessageClass CLASS_3
			{
				get
				{
					return default(global::android.telephony.gsm.SmsMessage.MessageClass);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN6645;
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
				global::android.telephony.gsm.SmsMessage.MessageClass._valueOf6639 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;");
				global::android.telephony.gsm.SmsMessage.MessageClass._values6640 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/gsm/SmsMessage/MessageClass;");
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
			internal static global::net.sf.jni4net.jni.MethodId _toString6646;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString6646));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._toString6646));
			}
			internal static global::net.sf.jni4net.jni.MethodId _SubmitPdu6647;
			public SubmitPdu()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu6647, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _encodedScAddress6648;
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
			internal static global::net.sf.jni4net.jni.FieldId _encodedMessage6649;
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
				global::android.telephony.gsm.SmsMessage.SubmitPdu._toString6646 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;");
				global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu6647 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUserData6650;
		public virtual byte[] getUserData() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getUserData6650));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getUserData6650));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatus6651;
		public virtual int getStatus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getStatus6651);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatus6651);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromPdu6652;
		public static global::android.telephony.gsm.SmsMessage createFromPdu(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._createFromPdu6652, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTPLayerLengthForPDU6653;
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU6653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6654;
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength6654, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6655;
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._calculateLength6655, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6656;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu6656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6657;
		public static global::android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getSubmitPdu6657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServiceCenterAddress6658;
		public virtual global::java.lang.String getServiceCenterAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress6658));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getServiceCenterAddress6658));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOriginatingAddress6659;
		public virtual global::java.lang.String getOriginatingAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getOriginatingAddress6659));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getOriginatingAddress6659));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayOriginatingAddress6660;
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress6660));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress6660));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMessageBody6661;
		public virtual global::java.lang.String getMessageBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getMessageBody6661));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageBody6661));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMessageClass6662;
		public virtual global::android.telephony.gsm.SmsMessage.MessageClass getMessageClass() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getMessageClass6662));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getMessageClass6662));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMessageBody6663;
		public virtual global::java.lang.String getDisplayMessageBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody6663));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getDisplayMessageBody6663));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPseudoSubject6664;
		public virtual global::java.lang.String getPseudoSubject() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getPseudoSubject6664));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPseudoSubject6664));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimestampMillis6665;
		public virtual long getTimestampMillis() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.telephony.gsm.SmsMessage._getTimestampMillis6665);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getTimestampMillis6665);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmail6666;
		public virtual bool isEmail() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isEmail6666);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isEmail6666);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmailBody6667;
		public virtual global::java.lang.String getEmailBody() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getEmailBody6667));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailBody6667));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEmailFrom6668;
		public virtual global::java.lang.String getEmailFrom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getEmailFrom6668));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getEmailFrom6668));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolIdentifier6669;
		public virtual int getProtocolIdentifier() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier6669);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getProtocolIdentifier6669);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReplace6670;
		public virtual bool isReplace() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isReplace6670);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplace6670);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCphsMwiMessage6671;
		public virtual bool isCphsMwiMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage6671);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isCphsMwiMessage6671);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMWIClearMessage6672;
		public virtual bool isMWIClearMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isMWIClearMessage6672);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWIClearMessage6672);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMWISetMessage6673;
		public virtual bool isMWISetMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isMWISetMessage6673);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMWISetMessage6673);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMwiDontStore6674;
		public virtual bool isMwiDontStore() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isMwiDontStore6674);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isMwiDontStore6674);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPdu6675;
		public virtual byte[] getPdu() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage._getPdu6675));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getPdu6675));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnSim6676;
		public virtual int getStatusOnSim() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getStatusOnSim6676);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getStatusOnSim6676);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnSim6677;
		public virtual int getIndexOnSim() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.SmsMessage._getIndexOnSim6677);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._getIndexOnSim6677);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStatusReportMessage6678;
		public virtual bool isStatusReportMessage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isStatusReportMessage6678);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isStatusReportMessage6678);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReplyPathPresent6679;
		public virtual bool isReplyPathPresent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.SmsMessage._isReplyPathPresent6679);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._isReplyPathPresent6679);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SmsMessage6680;
		public SmsMessage()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.gsm.SmsMessage.staticClass, global::android.telephony.gsm.SmsMessage._SmsMessage6680, this);
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
			global::android.telephony.gsm.SmsMessage._getUserData6650 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getUserData", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatus6651 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getStatus", "()I");
			global::android.telephony.gsm.SmsMessage._createFromPdu6652 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;");
			global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU6653 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I");
			global::android.telephony.gsm.SmsMessage._calculateLength6654 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I");
			global::android.telephony.gsm.SmsMessage._calculateLength6655 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu6656 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getSubmitPdu6657 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/SmsMessage$SubmitPdu;");
			global::android.telephony.gsm.SmsMessage._getServiceCenterAddress6658 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getOriginatingAddress6659 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress6660 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageBody6661 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getMessageClass6662 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;");
			global::android.telephony.gsm.SmsMessage._getDisplayMessageBody6663 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getPseudoSubject6664 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getTimestampMillis6665 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getTimestampMillis", "()J");
			global::android.telephony.gsm.SmsMessage._isEmail6666 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isEmail", "()Z");
			global::android.telephony.gsm.SmsMessage._getEmailBody6667 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getEmailFrom6668 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;");
			global::android.telephony.gsm.SmsMessage._getProtocolIdentifier6669 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getProtocolIdentifier", "()I");
			global::android.telephony.gsm.SmsMessage._isReplace6670 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isReplace", "()Z");
			global::android.telephony.gsm.SmsMessage._isCphsMwiMessage6671 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isCphsMwiMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWIClearMessage6672 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMWIClearMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMWISetMessage6673 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMWISetMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isMwiDontStore6674 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMwiDontStore", "()Z");
			global::android.telephony.gsm.SmsMessage._getPdu6675 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getPdu", "()[B");
			global::android.telephony.gsm.SmsMessage._getStatusOnSim6676 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getStatusOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._getIndexOnSim6677 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getIndexOnSim", "()I");
			global::android.telephony.gsm.SmsMessage._isStatusReportMessage6678 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isStatusReportMessage", "()Z");
			global::android.telephony.gsm.SmsMessage._isReplyPathPresent6679 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isReplyPathPresent", "()Z");
			global::android.telephony.gsm.SmsMessage._SmsMessage6680 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "<init>", "()V");
		}
	}
}
