namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SmsMessage : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SmsMessage() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.SmsMessage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.SmsMessage.MessageClass), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf6253; 
			public static android.telephony.SmsMessage.MessageClass valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.MessageClass.staticClass, _valueOf6253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values6254; 
			public static android.telephony.SmsMessage.MessageClass[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.MessageClass.staticClass, _values6254)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_06255; 
			public static android.telephony.SmsMessage.MessageClass CLASS_0
			{ 
				get 
				{ 
					return default(android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_16256; 
			public static android.telephony.SmsMessage.MessageClass CLASS_1
			{ 
				get 
				{ 
					return default(android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_26257; 
			public static android.telephony.SmsMessage.MessageClass CLASS_2
			{ 
				get 
				{ 
					return default(android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLASS_36258; 
			public static android.telephony.SmsMessage.MessageClass CLASS_3
			{ 
				get 
				{ 
					return default(android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN6259; 
			public static android.telephony.SmsMessage.MessageClass UNKNOWN
			{ 
				get 
				{ 
					return default(android.telephony.SmsMessage.MessageClass); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.telephony.SmsMessage.MessageClass.staticClass = @__class; 
				global::android.telephony.SmsMessage.MessageClass._valueOf6253 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.MessageClass.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;"); 
				global::android.telephony.SmsMessage.MessageClass._values6254 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.MessageClass.staticClass, "values", "()[Landroid/telephony/SmsMessage/MessageClass;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SubmitPdu : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static SubmitPdu() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.SmsMessage.SubmitPdu), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString6260; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.telephony.SmsMessage.SubmitPdu)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6260)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.SubmitPdu.staticClass, _toString6260)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _encodedScAddress6261; 
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
			internal static global::net.sf.jni4net.jni.FieldId _encodedMessage6262; 
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
				global::android.telephony.SmsMessage.SubmitPdu._toString6260 = @__env.GetMethodID(global::android.telephony.SmsMessage.SubmitPdu.staticClass, "toString", "()Ljava/lang/String;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUserData6263; 
		public virtual byte[] getUserData() 
		{ 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getUserData6263)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getUserData6263)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatus6264; 
		public virtual int getStatus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallIntMethod(this, _getStatus6264); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SmsMessage.staticClass, _getStatus6264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromPdu6265; 
		public static android.telephony.SmsMessage createFromPdu(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, _createFromPdu6265, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTPLayerLengthForPDU6266; 
		public static int getTPLayerLengthForPDU(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.telephony.SmsMessage.staticClass, _getTPLayerLengthForPDU6266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6267; 
		public static int[] calculateLength(java.lang.CharSequence arg0, bool arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, _calculateLength6267, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calculateLength6268; 
		public static int[] calculateLength(java.lang.String arg0, bool arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, _calculateLength6268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6269; 
		public static android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, _getSubmitPdu6269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubmitPdu6270; 
		public static android.telephony.SmsMessage.SubmitPdu getSubmitPdu(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.SubmitPdu>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsMessage.staticClass, _getSubmitPdu6270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceCenterAddress6271; 
		public virtual java.lang.String getServiceCenterAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getServiceCenterAddress6271)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getServiceCenterAddress6271)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginatingAddress6272; 
		public virtual java.lang.String getOriginatingAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOriginatingAddress6272)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getOriginatingAddress6272)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayOriginatingAddress6273; 
		public virtual java.lang.String getDisplayOriginatingAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayOriginatingAddress6273)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getDisplayOriginatingAddress6273)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessageBody6274; 
		public virtual java.lang.String getMessageBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getMessageBody6274)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getMessageBody6274)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMessageClass6275; 
		public virtual android.telephony.SmsMessage.MessageClass getMessageClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallObjectMethodPtr(this, _getMessageClass6275)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsMessage.MessageClass>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getMessageClass6275)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayMessageBody6276; 
		public virtual java.lang.String getDisplayMessageBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayMessageBody6276)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getDisplayMessageBody6276)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPseudoSubject6277; 
		public virtual java.lang.String getPseudoSubject() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPseudoSubject6277)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getPseudoSubject6277)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimestampMillis6278; 
		public virtual long getTimestampMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallLongMethod(this, _getTimestampMillis6278); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.telephony.SmsMessage.staticClass, _getTimestampMillis6278); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmail6279; 
		public virtual bool isEmail() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isEmail6279); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isEmail6279); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmailBody6280; 
		public virtual java.lang.String getEmailBody() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getEmailBody6280)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getEmailBody6280)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmailFrom6281; 
		public virtual java.lang.String getEmailFrom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getEmailFrom6281)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getEmailFrom6281)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProtocolIdentifier6282; 
		public virtual int getProtocolIdentifier() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallIntMethod(this, _getProtocolIdentifier6282); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SmsMessage.staticClass, _getProtocolIdentifier6282); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReplace6283; 
		public virtual bool isReplace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isReplace6283); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isReplace6283); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCphsMwiMessage6284; 
		public virtual bool isCphsMwiMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isCphsMwiMessage6284); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isCphsMwiMessage6284); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMWIClearMessage6285; 
		public virtual bool isMWIClearMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isMWIClearMessage6285); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isMWIClearMessage6285); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMWISetMessage6286; 
		public virtual bool isMWISetMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isMWISetMessage6286); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isMWISetMessage6286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMwiDontStore6287; 
		public virtual bool isMwiDontStore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isMwiDontStore6287); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isMwiDontStore6287); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPdu6288; 
		public virtual byte[] getPdu() 
		{ 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getPdu6288)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsMessage.staticClass, _getPdu6288)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnSim6289; 
		public virtual int getStatusOnSim() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallIntMethod(this, _getStatusOnSim6289); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SmsMessage.staticClass, _getStatusOnSim6289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatusOnIcc6290; 
		public virtual int getStatusOnIcc() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallIntMethod(this, _getStatusOnIcc6290); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SmsMessage.staticClass, _getStatusOnIcc6290); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnSim6291; 
		public virtual int getIndexOnSim() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallIntMethod(this, _getIndexOnSim6291); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SmsMessage.staticClass, _getIndexOnSim6291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIndexOnIcc6292; 
		public virtual int getIndexOnIcc() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallIntMethod(this, _getIndexOnIcc6292); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SmsMessage.staticClass, _getIndexOnIcc6292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStatusReportMessage6293; 
		public virtual bool isStatusReportMessage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isStatusReportMessage6293); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isStatusReportMessage6293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReplyPathPresent6294; 
		public virtual bool isReplyPathPresent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsMessage)) 
				return @__env.CallBooleanMethod(this, _isReplyPathPresent6294); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SmsMessage.staticClass, _isReplyPathPresent6294); 
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
			global::android.telephony.SmsMessage._getUserData6263 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getUserData", "()[B"); 
			global::android.telephony.SmsMessage._getStatus6264 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatus", "()I"); 
			global::android.telephony.SmsMessage._createFromPdu6265 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "createFromPdu", "([B)Landroid/telephony/SmsMessage;"); 
			global::android.telephony.SmsMessage._getTPLayerLengthForPDU6266 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getTPLayerLengthForPDU", "(Ljava/lang/String;)I"); 
			global::android.telephony.SmsMessage._calculateLength6267 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/CharSequence;Z)[I"); 
			global::android.telephony.SmsMessage._calculateLength6268 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "calculateLength", "(Ljava/lang/String;Z)[I"); 
			global::android.telephony.SmsMessage._getSubmitPdu6269 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu;"); 
			global::android.telephony.SmsMessage._getSubmitPdu6270 = @__env.GetStaticMethodID(global::android.telephony.SmsMessage.staticClass, "getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/SmsMessage$SubmitPdu;"); 
			global::android.telephony.SmsMessage._getServiceCenterAddress6271 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getServiceCenterAddress", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getOriginatingAddress6272 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getOriginatingAddress", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getDisplayOriginatingAddress6273 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getDisplayOriginatingAddress", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getMessageBody6274 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getMessageBody", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getMessageClass6275 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;"); 
			global::android.telephony.SmsMessage._getDisplayMessageBody6276 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getDisplayMessageBody", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getPseudoSubject6277 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getPseudoSubject", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getTimestampMillis6278 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getTimestampMillis", "()J"); 
			global::android.telephony.SmsMessage._isEmail6279 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isEmail", "()Z"); 
			global::android.telephony.SmsMessage._getEmailBody6280 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getEmailBody", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getEmailFrom6281 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getEmailFrom", "()Ljava/lang/String;"); 
			global::android.telephony.SmsMessage._getProtocolIdentifier6282 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getProtocolIdentifier", "()I"); 
			global::android.telephony.SmsMessage._isReplace6283 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isReplace", "()Z"); 
			global::android.telephony.SmsMessage._isCphsMwiMessage6284 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isCphsMwiMessage", "()Z"); 
			global::android.telephony.SmsMessage._isMWIClearMessage6285 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMWIClearMessage", "()Z"); 
			global::android.telephony.SmsMessage._isMWISetMessage6286 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMWISetMessage", "()Z"); 
			global::android.telephony.SmsMessage._isMwiDontStore6287 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isMwiDontStore", "()Z"); 
			global::android.telephony.SmsMessage._getPdu6288 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getPdu", "()[B"); 
			global::android.telephony.SmsMessage._getStatusOnSim6289 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatusOnSim", "()I"); 
			global::android.telephony.SmsMessage._getStatusOnIcc6290 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getStatusOnIcc", "()I"); 
			global::android.telephony.SmsMessage._getIndexOnSim6291 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getIndexOnSim", "()I"); 
			global::android.telephony.SmsMessage._getIndexOnIcc6292 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "getIndexOnIcc", "()I"); 
			global::android.telephony.SmsMessage._isStatusReportMessage6293 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isStatusReportMessage", "()Z"); 
			global::android.telephony.SmsMessage._isReplyPathPresent6294 = @__env.GetMethodID(global::android.telephony.SmsMessage.staticClass, "isReplyPathPresent", "()Z"); 
		} 
	} 
} 
