namespace android.telephony.gsm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SmsMessage : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SmsMessage() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.gsm.SmsMessage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.gsm.SmsMessage.MessageClass), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf6351; 
			public static android.telephony.gsm.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.MessageClass.staticClass, _valueOf6351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values6352; 
			public static android.telephony.gsm.SmsMessage.MessageClass[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.MessageClass.staticClass, _values6352)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_06353; 
			public static android.telephony.gsm.SmsMessage.MessageClass CLASS_0
			{ 
				get 
				{ 
					return default(android.telephony.gsm.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_16354; 
			public static android.telephony.gsm.SmsMessage.MessageClass CLASS_1
			{ 
				get 
				{ 
					return default(android.telephony.gsm.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_26355; 
			public static android.telephony.gsm.SmsMessage.MessageClass CLASS_2
			{ 
				get 
				{ 
					return default(android.telephony.gsm.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_36356; 
			public static android.telephony.gsm.SmsMessage.MessageClass CLASS_3
			{ 
				get 
				{ 
					return default(android.telephony.gsm.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN6357; 
			public static android.telephony.gsm.SmsMessage.MessageClass UNKNOWN
			{ 
				get 
				{ 
					return default(android.telephony.gsm.SmsMessage.MessageClass); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.telephony.gsm.SmsMessage.MessageClass.staticClass = @__class; 
				global::android.telephony.gsm.SmsMessage.MessageClass._valueOf6351 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;"); 
				global::android.telephony.gsm.SmsMessage.MessageClass._values6352 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/gsm/SmsMessage/MessageClass;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SubmitPdu : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static SubmitPdu() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.gsm.SmsMessage.SubmitPdu), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString6358; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.telephony.gsm.SmsMessage.SubmitPdu)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6358)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, _toString6358)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SubmitPdu6359; 
			public SubmitPdu()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, _SubmitPdu6359, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _encodedScAddress6360; 
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
			internal static global::net.sf.jni4net.jni.FieldId _encodedMessage6361; 
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
				global::android.telephony.gsm.SmsMessage.SubmitPdu._toString6358 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.telephony.gsm.SmsMessage.SubmitPdu._SubmitPdu6359 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.SubmitPdu.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserData6362; 
		public virtual byte[] getUserData() 
		{ 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getUserData6362)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getUserData6362)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatus6363; 
		public virtual int getStatus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallIntMethod(this, _getStatus6363); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.gsm.SmsMessage.staticClass, _getStatus6363); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromPdu6364; 
		public static android.telephony.gsm.SmsMessage createFromPdu(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, _createFromPdu6364, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTPLayerLengthForPDU6365; 
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.telephony.gsm.SmsMessage.staticClass, _getTPLayerLengthForPDU6365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6366; 
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, _calculateLength6366, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6367; 
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, _calculateLength6367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6368; 
		public static android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, _getSubmitPdu6368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6369; 
		public static android.telephony.gsm.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.gsm.SmsMessage.staticClass, _getSubmitPdu6369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceCenterAddress6370; 
		public virtual java.lang.String getServiceCenterAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getServiceCenterAddress6370)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getServiceCenterAddress6370)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginatingAddress6371; 
		public virtual java.lang.String getOriginatingAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOriginatingAddress6371)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getOriginatingAddress6371)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayOriginatingAddress6372; 
		public virtual java.lang.String getDisplayOriginatingAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayOriginatingAddress6372)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getDisplayOriginatingAddress6372)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessageBody6373; 
		public virtual java.lang.String getMessageBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getMessageBody6373)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getMessageBody6373)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessageClass6374; 
		public virtual android.telephony.gsm.SmsMessage.MessageClass getMessageClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallObjectMethodPtr(this, _getMessageClass6374)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.gsm.SmsMessage.MessageClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getMessageClass6374)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMessageBody6375; 
		public virtual java.lang.String getDisplayMessageBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayMessageBody6375)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getDisplayMessageBody6375)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPseudoSubject6376; 
		public virtual java.lang.String getPseudoSubject() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPseudoSubject6376)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getPseudoSubject6376)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimestampMillis6377; 
		public virtual long getTimestampMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallLongMethod(this, _getTimestampMillis6377); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.telephony.gsm.SmsMessage.staticClass, _getTimestampMillis6377); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmail6378; 
		public virtual bool isEmail() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isEmail6378); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isEmail6378); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmailBody6379; 
		public virtual java.lang.String getEmailBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getEmailBody6379)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getEmailBody6379)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmailFrom6380; 
		public virtual java.lang.String getEmailFrom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getEmailFrom6380)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getEmailFrom6380)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolIdentifier6381; 
		public virtual int getProtocolIdentifier() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallIntMethod(this, _getProtocolIdentifier6381); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.gsm.SmsMessage.staticClass, _getProtocolIdentifier6381); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReplace6382; 
		public virtual bool isReplace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isReplace6382); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isReplace6382); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCphsMwiMessage6383; 
		public virtual bool isCphsMwiMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isCphsMwiMessage6383); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isCphsMwiMessage6383); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMWIClearMessage6384; 
		public virtual bool isMWIClearMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isMWIClearMessage6384); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isMWIClearMessage6384); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMWISetMessage6385; 
		public virtual bool isMWISetMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isMWISetMessage6385); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isMWISetMessage6385); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMwiDontStore6386; 
		public virtual bool isMwiDontStore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isMwiDontStore6386); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isMwiDontStore6386); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPdu6387; 
		public virtual byte[] getPdu() 
		{ 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getPdu6387)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.SmsMessage.staticClass, _getPdu6387)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnSim6388; 
		public virtual int getStatusOnSim() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallIntMethod(this, _getStatusOnSim6388); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.gsm.SmsMessage.staticClass, _getStatusOnSim6388); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnSim6389; 
		public virtual int getIndexOnSim() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallIntMethod(this, _getIndexOnSim6389); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.gsm.SmsMessage.staticClass, _getIndexOnSim6389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStatusReportMessage6390; 
		public virtual bool isStatusReportMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isStatusReportMessage6390); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isStatusReportMessage6390); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReplyPathPresent6391; 
		public virtual bool isReplyPathPresent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isReplyPathPresent6391); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.SmsMessage.staticClass, _isReplyPathPresent6391); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SmsMessage6392; 
		public SmsMessage()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.gsm.SmsMessage.staticClass, _SmsMessage6392, this); 
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
			global::android.telephony.gsm.SmsMessage._getUserData6362 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getUserData", "()[B"); 
			global::android.telephony.gsm.SmsMessage._getStatus6363 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getStatus", "()I"); 
			global::android.telephony.gsm.SmsMessage._createFromPdu6364 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;"); 
			global::android.telephony.gsm.SmsMessage._getTPLayerLengthForPDU6365 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I"); 
			global::android.telephony.gsm.SmsMessage._calculateLength6366 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I"); 
			global::android.telephony.gsm.SmsMessage._calculateLength6367 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I"); 
			global::android.telephony.gsm.SmsMessage._getSubmitPdu6368 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$SubmitPdu;"); 
			global::android.telephony.gsm.SmsMessage._getSubmitPdu6369 = @__env.GetStaticMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/SmsMessage$SubmitPdu;"); 
			global::android.telephony.gsm.SmsMessage._getServiceCenterAddress6370 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getOriginatingAddress6371 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getDisplayOriginatingAddress6372 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getMessageBody6373 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getMessageClass6374 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;"); 
			global::android.telephony.gsm.SmsMessage._getDisplayMessageBody6375 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getPseudoSubject6376 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getTimestampMillis6377 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getTimestampMillis", "()J"); 
			global::android.telephony.gsm.SmsMessage._isEmail6378 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isEmail", "()Z"); 
			global::android.telephony.gsm.SmsMessage._getEmailBody6379 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getEmailFrom6380 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.SmsMessage._getProtocolIdentifier6381 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getProtocolIdentifier", "()I"); 
			global::android.telephony.gsm.SmsMessage._isReplace6382 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isReplace", "()Z"); 
			global::android.telephony.gsm.SmsMessage._isCphsMwiMessage6383 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isCphsMwiMessage", "()Z"); 
			global::android.telephony.gsm.SmsMessage._isMWIClearMessage6384 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMWIClearMessage", "()Z"); 
			global::android.telephony.gsm.SmsMessage._isMWISetMessage6385 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMWISetMessage", "()Z"); 
			global::android.telephony.gsm.SmsMessage._isMwiDontStore6386 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isMwiDontStore", "()Z"); 
			global::android.telephony.gsm.SmsMessage._getPdu6387 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getPdu", "()[B"); 
			global::android.telephony.gsm.SmsMessage._getStatusOnSim6388 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getStatusOnSim", "()I"); 
			global::android.telephony.gsm.SmsMessage._getIndexOnSim6389 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "getIndexOnSim", "()I"); 
			global::android.telephony.gsm.SmsMessage._isStatusReportMessage6390 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isStatusReportMessage", "()Z"); 
			global::android.telephony.gsm.SmsMessage._isReplyPathPresent6391 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "isReplyPathPresent", "()Z"); 
			global::android.telephony.gsm.SmsMessage._SmsMessage6392 = @__env.GetMethodID(global::android.telephony.gsm.SmsMessage.staticClass, "<init>", "()V"); 
		} 
	} 
} 
