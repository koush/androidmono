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
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException687; 
			public CanceledException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, _CanceledException687, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException688; 
			public CanceledException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, _CanceledException688, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException689; 
			public CanceledException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, _CanceledException689, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.PendingIntent.CanceledException.staticClass = @__class; 
				global::android.app.PendingIntent.CanceledException._CanceledException687 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "()V"); 
				global::android.app.PendingIntent.CanceledException._CanceledException688 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
				global::android.app.PendingIntent.CanceledException._CanceledException689 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/Exception;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnFinished 
		{ 
			void onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4); 
		} 

		public partial class OnFinished_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnFinished.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnFinished : java.lang.Object, OnFinished
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnFinished() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.PendingIntent.__OnFinished), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.PendingIntent.__OnFinished(@__env); 
				} 
			} 
			internal __OnFinished(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSendFinished690; 
			 void android.app.PendingIntent.OnFinished.onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.PendingIntent.__OnFinished)) 
					@__env.CallVoidMethod(this, _onSendFinished690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.__OnFinished.staticClass, _onSendFinished690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.PendingIntent.__OnFinished.staticClass = @__class; 
				global::android.app.PendingIntent.__OnFinished._onSendFinished690 = @__env.GetMethodID(global::android.app.PendingIntent.__OnFinished.staticClass, "android.app.PendingIntent.OnFinished.onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode691; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return @__env.CallIntMethod(this, _hashCode691); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.PendingIntent.staticClass, _hashCode691); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals692; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return @__env.CallBooleanMethod(this, _equals692, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.PendingIntent.staticClass, _equals692, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString693; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString693)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.PendingIntent.staticClass, _toString693)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send694; 
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send695; 
		public void send() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send695); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send695); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send696; 
		public void send(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send697; 
		public void send(int arg0, android.app.PendingIntent.OnFinished arg1, android.os.Handler arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send698; 
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, android.app.PendingIntent.OnFinished arg3, android.os.Handler arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _send698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _send698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getService699; 
		public static android.app.PendingIntent getService(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _getService699, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel700; 
		public void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _cancel700); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _cancel700); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel701; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				@__env.CallVoidMethod(this, _writeToParcel701, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.PendingIntent.staticClass, _writeToParcel701, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents702; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return @__env.CallIntMethod(this, _describeContents702); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.PendingIntent.staticClass, _describeContents702); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActivity703; 
		public static android.app.PendingIntent getActivity(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _getActivity703, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcast704; 
		public static android.app.PendingIntent getBroadcast(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _getBroadcast704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntentSender705; 
		public android.content.IntentSender getIntentSender() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallObjectMethodPtr(this, _getIntentSender705)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.PendingIntent.staticClass, _getIntentSender705)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTargetPackage706; 
		public java.lang.String getTargetPackage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.PendingIntent)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTargetPackage706)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.PendingIntent.staticClass, _getTargetPackage706)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writePendingIntentOrNullToParcel707; 
		public static void writePendingIntentOrNullToParcel(android.app.PendingIntent arg0, android.os.Parcel arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.app.PendingIntent.staticClass, _writePendingIntentOrNullToParcel707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readPendingIntentOrNullFromParcel708; 
		public static android.app.PendingIntent readPendingIntentOrNullFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, _readPendingIntentOrNullFromParcel708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR709; 
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
			global::android.app.PendingIntent._hashCode691 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "hashCode", "()I"); 
			global::android.app.PendingIntent._equals692 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.app.PendingIntent._toString693 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.app.PendingIntent._send694 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;)V"); 
			global::android.app.PendingIntent._send695 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "()V"); 
			global::android.app.PendingIntent._send696 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(I)V"); 
			global::android.app.PendingIntent._send697 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V"); 
			global::android.app.PendingIntent._send698 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V"); 
			global::android.app.PendingIntent._getService699 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;"); 
			global::android.app.PendingIntent._cancel700 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "cancel", "()V"); 
			global::android.app.PendingIntent._writeToParcel701 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.app.PendingIntent._describeContents702 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "describeContents", "()I"); 
			global::android.app.PendingIntent._getActivity703 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;"); 
			global::android.app.PendingIntent._getBroadcast704 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;"); 
			global::android.app.PendingIntent._getIntentSender705 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "getIntentSender", "()Landroid/content/IntentSender;"); 
			global::android.app.PendingIntent._getTargetPackage706 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "getTargetPackage", "()Ljava/lang/String;"); 
			global::android.app.PendingIntent._writePendingIntentOrNullToParcel707 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V"); 
			global::android.app.PendingIntent._readPendingIntentOrNullFromParcel708 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;"); 
		} 
	} 
} 
