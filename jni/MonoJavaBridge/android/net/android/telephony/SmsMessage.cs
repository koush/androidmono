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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf6541; 
			public static global::android.telephony.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._valueOf6541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values6542; 
			public static global::android.telephony.SmsMessage.MessageClass[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.MessageClass.staticClass, global::android.telephony.SmsMessage.MessageClass._values6542)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_06543; 
			public static global::android.telephony.SmsMessage.MessageClass CLASS_0
			{ 
				get 
				{ 
					return default(global::android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_16544; 
			public static global::android.telephony.SmsMessage.MessageClass CLASS_1
			{ 
				get 
				{ 
					return default(global::android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_26545; 
			public static global::android.telephony.SmsMessage.MessageClass CLASS_2
			{ 
				get 
				{ 
					return default(global::android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_36546; 
			public static global::android.telephony.SmsMessage.MessageClass CLASS_3
			{ 
				get 
				{ 
					return default(global::android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN6547; 
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
				global::android.telephony.SmsMessage.MessageClass._valueOf6541 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;"); 
				global::android.telephony.SmsMessage.MessageClass._values6542 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/SmsMessage/MessageClass;"); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString6548; 
			public override global::java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage.SubmitPdu._toString6548)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.SubmitPdu.staticClass, global::android.telephony.SmsMessage.SubmitPdu._toString6548)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _encodedScAddress6549; 
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
			internal static global::net.sf.jni4net.jni.FieldId _encodedMessage6550; 
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
				global::android.telephony.SmsMessage.SubmitPdu._toString6548 = @__env.GetMethodID(global::android.telephony.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserData6551; 
		public virtual byte[] getUserData() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getUserData6551)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getUserData6551)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatus6552; 
		public virtual int getStatus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getStatus6552); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatus6552); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromPdu6553; 
		public static global::android.telephony.SmsMessage createFromPdu(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._createFromPdu6553, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTPLayerLengthForPDU6554; 
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTPLayerLengthForPDU6554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6555; 
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength6555, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6556; 
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._calculateLength6556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6557; 
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu6557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6558; 
		public static global::android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getSubmitPdu6558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceCenterAddress6559; 
		public virtual global::java.lang.String getServiceCenterAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getServiceCenterAddress6559)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getServiceCenterAddress6559)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginatingAddress6560; 
		public virtual global::java.lang.String getOriginatingAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getOriginatingAddress6560)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getOriginatingAddress6560)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayOriginatingAddress6561; 
		public virtual global::java.lang.String getDisplayOriginatingAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getDisplayOriginatingAddress6561)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayOriginatingAddress6561)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessageBody6562; 
		public virtual global::java.lang.String getMessageBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getMessageBody6562)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageBody6562)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessageClass6563; 
		public virtual global::android.telephony.SmsMessage.MessageClass getMessageClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getMessageClass6563)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getMessageClass6563)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMessageBody6564; 
		public virtual global::java.lang.String getDisplayMessageBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getDisplayMessageBody6564)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getDisplayMessageBody6564)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPseudoSubject6565; 
		public virtual global::java.lang.String getPseudoSubject() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getPseudoSubject6565)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPseudoSubject6565)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimestampMillis6566; 
		public virtual long getTimestampMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.telephony.SmsMessage._getTimestampMillis6566); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getTimestampMillis6566); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmail6567; 
		public virtual bool isEmail() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isEmail6567); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isEmail6567); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmailBody6568; 
		public virtual global::java.lang.String getEmailBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getEmailBody6568)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailBody6568)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmailFrom6569; 
		public virtual global::java.lang.String getEmailFrom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getEmailFrom6569)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getEmailFrom6569)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolIdentifier6570; 
		public virtual int getProtocolIdentifier() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getProtocolIdentifier6570); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getProtocolIdentifier6570); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReplace6571; 
		public virtual bool isReplace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isReplace6571); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplace6571); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCphsMwiMessage6572; 
		public virtual bool isCphsMwiMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isCphsMwiMessage6572); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isCphsMwiMessage6572); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMWIClearMessage6573; 
		public virtual bool isMWIClearMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isMWIClearMessage6573); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWIClearMessage6573); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMWISetMessage6574; 
		public virtual bool isMWISetMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isMWISetMessage6574); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMWISetMessage6574); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMwiDontStore6575; 
		public virtual bool isMwiDontStore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isMwiDontStore6575); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isMwiDontStore6575); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPdu6576; 
		public virtual byte[] getPdu() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SmsMessage._getPdu6576)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getPdu6576)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnSim6577; 
		public virtual int getStatusOnSim() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getStatusOnSim6577); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnSim6577); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnIcc6578; 
		public virtual int getStatusOnIcc() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getStatusOnIcc6578); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getStatusOnIcc6578); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnSim6579; 
		public virtual int getIndexOnSim() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getIndexOnSim6579); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnSim6579); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnIcc6580; 
		public virtual int getIndexOnIcc() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.SmsMessage._getIndexOnIcc6580); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._getIndexOnIcc6580); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStatusReportMessage6581; 
		public virtual bool isStatusReportMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isStatusReportMessage6581); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isStatusReportMessage6581); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReplyPathPresent6582; 
		public virtual bool isReplyPathPresent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.SmsMessage._isReplyPathPresent6582); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SmsMessage.staticClass, global::android.telephony.SmsMessage._isReplyPathPresent6582); 
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
			global::android.telephony.SmsMessage._getUserData6551 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getUserData", "()[B"); 
			global::android.telephony.SmsMessage._getStatus6552 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatus", "()I"); 
			global::android.telephony.SmsMessage._createFromPdu6553 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/SmsMessage;"); 
			global::android.telephony.SmsMessage._getTPLayerLengthForPDU6554 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I"); 
			global::android.telephony.SmsMessage._calculateLength6555 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I"); 
			global::android.telephony.SmsMessage._calculateLength6556 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I"); 
			global::android.telephony.SmsMessage._getSubmitPdu6557 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu;"); 
			global::android.telephony.SmsMessage._getSubmitPdu6558 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/SmsMessage$SubmitPdu;"); 
			global::android.telephony.SmsMessage._getServiceCenterAddress6559 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getOriginatingAddress6560 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getDisplayOriginatingAddress6561 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getMessageBody6562 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getMessageClass6563 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;"); 
			global::android.telephony.SmsMessage._getDisplayMessageBody6564 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getPseudoSubject6565 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getTimestampMillis6566 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getTimestampMillis", "()J"); 
			global::android.telephony.SmsMessage._isEmail6567 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isEmail", "()Z"); 
			global::android.telephony.SmsMessage._getEmailBody6568 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getEmailFrom6569 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getProtocolIdentifier6570 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getProtocolIdentifier", "()I"); 
			global::android.telephony.SmsMessage._isReplace6571 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isReplace", "()Z"); 
			global::android.telephony.SmsMessage._isCphsMwiMessage6572 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isCphsMwiMessage", "()Z"); 
			global::android.telephony.SmsMessage._isMWIClearMessage6573 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMWIClearMessage", "()Z"); 
			global::android.telephony.SmsMessage._isMWISetMessage6574 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMWISetMessage", "()Z"); 
			global::android.telephony.SmsMessage._isMwiDontStore6575 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMwiDontStore", "()Z"); 
			global::android.telephony.SmsMessage._getPdu6576 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getPdu", "()[B"); 
			global::android.telephony.SmsMessage._getStatusOnSim6577 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatusOnSim", "()I"); 
			global::android.telephony.SmsMessage._getStatusOnIcc6578 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatusOnIcc", "()I"); 
			global::android.telephony.SmsMessage._getIndexOnSim6579 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getIndexOnSim", "()I"); 
			global::android.telephony.SmsMessage._getIndexOnIcc6580 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getIndexOnIcc", "()I"); 
			global::android.telephony.SmsMessage._isStatusReportMessage6581 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isStatusReportMessage", "()Z"); 
			global::android.telephony.SmsMessage._isReplyPathPresent6582 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isReplyPathPresent", "()Z"); 
		} 
	} 
} 
