namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class PendingIntent : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static PendingIntent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.PendingIntent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.PendingIntent(@__env); 
			} 
		} 
		internal PendingIntent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class CanceledException : android.util.AndroidException
		{ 
			internal new static global::java.lang.Class staticClass; 
			static CanceledException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.PendingIntent.CanceledException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.PendingIntent.CanceledException(@__env); 
				} 
			} 
			protected CanceledException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException678; 
			public CanceledException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, _CanceledException678, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException679; 
			public CanceledException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, _CanceledException679, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException680; 
			public CanceledException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, _CanceledException680, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.PendingIntent.CanceledException.staticClass = @__class; 
				global::android.app.PendingIntent.CanceledException._CanceledException678 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "()V"); 
				global::android.app.PendingIntent.CanceledException._CanceledException679 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
				global::android.app.PendingIntent.CanceledException._CanceledException680 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/Exception;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnFinished 
		{ 
			void onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode681; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return @__env.CallIntMethod(this, _hashCode681); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.PendingIntent.staticClass, _hashCode681); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals682; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return @__env.CallBooleanMethod(this, _equals682, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.PendingIntent.staticClass, _equals682, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString683; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString683)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.PendingIntent.staticClass, _toString683)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send684; 
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send685; 
		public void send() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send685); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send685); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send686; 
		public void send(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send687; 
		public void send(int arg0, android.app.PendingIntent.OnFinished arg1, android.os.Handler arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send688; 
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, android.app.PendingIntent.OnFinished arg3, android.os.Handler arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getService689; 
		public static android.app.PendingIntent getService(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _getService689, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel690; 
		public void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _cancel690); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _cancel690); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel691; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _writeToParcel691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _writeToParcel691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents692; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return @__env.CallIntMethod(this, _describeContents692); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.PendingIntent.staticClass, _describeContents692); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActivity693; 
		public static android.app.PendingIntent getActivity(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _getActivity693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcast694; 
		public static android.app.PendingIntent getBroadcast(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _getBroadcast694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntentSender695; 
		public android.content.IntentSender getIntentSender() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallObjectMethodPtr(this, _getIntentSender695)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.PendingIntent.staticClass, _getIntentSender695)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTargetPackage696; 
		public java.lang.String getTargetPackage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTargetPackage696)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.PendingIntent.staticClass, _getTargetPackage696)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writePendingIntentOrNullToParcel697; 
		public static void writePendingIntentOrNullToParcel(android.app.PendingIntent arg0, android.os.Parcel arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.app.PendingIntent.staticClass, _writePendingIntentOrNullToParcel697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readPendingIntentOrNullFromParcel698; 
		public static android.app.PendingIntent readPendingIntentOrNullFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _readPendingIntentOrNullFromParcel698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		public static int FLAG_ONE_SHOT
		{ 
			get 
			{ 
				return 1073741824; 
			} 
		} 
		public static int FLAG_NO_CREATE
		{ 
			get 
			{ 
				return 536870912; 
			} 
		} 
		public static int FLAG_CANCEL_CURRENT
		{ 
			get 
			{ 
				return 268435456; 
			} 
		} 
		public static int FLAG_UPDATE_CURRENT
		{ 
			get 
			{ 
				return 134217728; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR699; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.PendingIntent.staticClass = @__class; 
			global::android.app.PendingIntent._hashCode681 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "hashCode", "()I"); 
			global::android.app.PendingIntent._equals682 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.app.PendingIntent._toString683 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.app.PendingIntent._send684 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;)V"); 
			global::android.app.PendingIntent._send685 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "()V"); 
			global::android.app.PendingIntent._send686 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(I)V"); 
			global::android.app.PendingIntent._send687 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V"); 
			global::android.app.PendingIntent._send688 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V"); 
			global::android.app.PendingIntent._getService689 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;"); 
			global::android.app.PendingIntent._cancel690 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "cancel", "()V"); 
			global::android.app.PendingIntent._writeToParcel691 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.app.PendingIntent._describeContents692 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "describeContents", "()I"); 
			global::android.app.PendingIntent._getActivity693 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;"); 
			global::android.app.PendingIntent._getBroadcast694 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;"); 
			global::android.app.PendingIntent._getIntentSender695 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "getIntentSender", "()Landroid/content/IntentSender;"); 
			global::android.app.PendingIntent._getTargetPackage696 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "getTargetPackage", "()Ljava/lang/String;"); 
			global::android.app.PendingIntent._writePendingIntentOrNullToParcel697 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V"); 
			global::android.app.PendingIntent._readPendingIntentOrNullFromParcel698 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;"); 
		} 
	} 
} 
