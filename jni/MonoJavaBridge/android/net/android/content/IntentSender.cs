namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class IntentSender : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static IntentSender() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.IntentSender), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.IntentSender(@__env); 
			} 
		} 
		protected IntentSender(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnFinished 
		{ 
			void onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SendIntentException : android.util.AndroidException
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SendIntentException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.IntentSender.SendIntentException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.IntentSender.SendIntentException(@__env); 
				} 
			} 
			protected SendIntentException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SendIntentException1438; 
			public SendIntentException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, _SendIntentException1438, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SendIntentException1439; 
			public SendIntentException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, _SendIntentException1439, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SendIntentException1440; 
			public SendIntentException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, _SendIntentException1440, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.IntentSender.SendIntentException.staticClass = @__class; 
				global::android.content.IntentSender.SendIntentException._SendIntentException1438 = @__env.GetMethodID(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "()V"); 
				global::android.content.IntentSender.SendIntentException._SendIntentException1439 = @__env.GetMethodID(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
				global::android.content.IntentSender.SendIntentException._SendIntentException1440 = @__env.GetMethodID(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/Exception;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1441; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentSender)) 
				return @__env.CallIntMethod(this, _hashCode1441); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentSender.staticClass, _hashCode1441); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals1442; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentSender)) 
				return @__env.CallBooleanMethod(this, _equals1442, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.IntentSender.staticClass, _equals1442, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1443; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentSender)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1443)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.IntentSender.staticClass, _toString1443)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1444; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentSender)) 
				@__env.CallVoidMethod(this, _writeToParcel1444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentSender.staticClass, _writeToParcel1444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1445; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentSender)) 
				return @__env.CallIntMethod(this, _describeContents1445); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.IntentSender.staticClass, _describeContents1445); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendIntent1446; 
		public virtual void sendIntent(android.content.Context arg0, int arg1, android.content.Intent arg2, android.content.IntentSender.OnFinished arg3, android.os.Handler arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.IntentSender)) 
				@__env.CallVoidMethod(this, _sendIntent1446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.IntentSender.staticClass, _sendIntent1446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeIntentSenderOrNullToParcel1447; 
		public static void writeIntentSenderOrNullToParcel(android.content.IntentSender arg0, android.os.Parcel arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.IntentSender.staticClass, _writeIntentSenderOrNullToParcel1447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readIntentSenderOrNullFromParcel1448; 
		public static android.content.IntentSender readIntentSenderOrNullFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallStaticObjectMethodPtr(android.content.IntentSender.staticClass, _readIntentSenderOrNullFromParcel1448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1449; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.IntentSender.staticClass = @__class; 
			global::android.content.IntentSender._hashCode1441 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "hashCode", "()I"); 
			global::android.content.IntentSender._equals1442 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.content.IntentSender._toString1443 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.IntentSender._writeToParcel1444 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.IntentSender._describeContents1445 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "describeContents", "()I"); 
			global::android.content.IntentSender._sendIntent1446 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$OnFinished;Landroid/os/Handler;)V"); 
			global::android.content.IntentSender._writeIntentSenderOrNullToParcel1447 = @__env.GetStaticMethodID(global::android.content.IntentSender.staticClass, "writeIntentSenderOrNullToParcel", "(Landroid/content/IntentSender;Landroid/os/Parcel;)V"); 
			global::android.content.IntentSender._readIntentSenderOrNullFromParcel1448 = @__env.GetStaticMethodID(global::android.content.IntentSender.staticClass, "readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;"); 
		} 
	} 
} 
