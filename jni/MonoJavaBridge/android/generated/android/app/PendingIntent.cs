namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class PendingIntent : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static PendingIntent()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.PendingIntent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.PendingIntent.CanceledException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException697;
			public CanceledException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException697, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException698;
			public CanceledException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException698, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _CanceledException699;
			public CanceledException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.PendingIntent.CanceledException.staticClass, global::android.app.PendingIntent.CanceledException._CanceledException699, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.PendingIntent.CanceledException.staticClass = @__class;
				global::android.app.PendingIntent.CanceledException._CanceledException697 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "()V");
				global::android.app.PendingIntent.CanceledException._CanceledException698 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::android.app.PendingIntent.CanceledException._CanceledException699 = @__env.GetMethodID(global::android.app.PendingIntent.CanceledException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.PendingIntent.__OnFinished), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _onSendFinished700;
			 void android.app.PendingIntent.OnFinished.onSendFinished(android.app.PendingIntent arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.PendingIntent.__OnFinished._onSendFinished700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.__OnFinished.staticClass, global::android.app.PendingIntent.__OnFinished._onSendFinished700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.PendingIntent.__OnFinished.staticClass = @__class;
				global::android.app.PendingIntent.__OnFinished._onSendFinished700 = @__env.GetMethodID(global::android.app.PendingIntent.__OnFinished.staticClass, "android.app.PendingIntent.OnFinished.onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals701;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.PendingIntent._equals701, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._equals701, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString702;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.PendingIntent._toString702));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._toString702));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode703;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.PendingIntent._hashCode703);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._hashCode703);
		}
		internal static global::net.sf.jni4net.jni.MethodId _send704;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.PendingIntent._send704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send704, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _send705;
		public void send() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.PendingIntent._send705);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send705);
		}
		internal static global::net.sf.jni4net.jni.MethodId _send706;
		public void send(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.PendingIntent._send706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _send707;
		public void send(int arg0, android.app.PendingIntent.OnFinished arg1, android.os.Handler arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.PendingIntent._send707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _send708;
		public void send(android.content.Context arg0, int arg1, android.content.Intent arg2, android.app.PendingIntent.OnFinished arg3, android.os.Handler arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.PendingIntent._send708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._send708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getService709;
		public static global::android.app.PendingIntent getService(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getService709, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel710;
		public void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.PendingIntent._cancel710);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._cancel710);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel711;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.PendingIntent._writeToParcel711, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writeToParcel711, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents712;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.PendingIntent._describeContents712);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._describeContents712);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActivity713;
		public static global::android.app.PendingIntent getActivity(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getActivity713, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcast714;
		public static global::android.app.PendingIntent getBroadcast(android.content.Context arg0, int arg1, android.content.Intent arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getBroadcast714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntentSender715;
		public global::android.content.IntentSender getIntentSender() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.PendingIntent._getIntentSender715));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getIntentSender715));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTargetPackage716;
		public global::java.lang.String getTargetPackage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.PendingIntent._getTargetPackage716));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.PendingIntent.staticClass, global::android.app.PendingIntent._getTargetPackage716));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writePendingIntentOrNullToParcel717;
		public static void writePendingIntentOrNullToParcel(android.app.PendingIntent arg0, android.os.Parcel arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._writePendingIntentOrNullToParcel717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readPendingIntentOrNullFromParcel718;
		public static global::android.app.PendingIntent readPendingIntentOrNullFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallStaticObjectMethodPtr(android.app.PendingIntent.staticClass, global::android.app.PendingIntent._readPendingIntentOrNullFromParcel718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR719;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.PendingIntent.staticClass = @__class;
			global::android.app.PendingIntent._equals701 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.app.PendingIntent._toString702 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.PendingIntent._hashCode703 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "hashCode", "()I");
			global::android.app.PendingIntent._send704 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;)V");
			global::android.app.PendingIntent._send705 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "()V");
			global::android.app.PendingIntent._send706 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(I)V");
			global::android.app.PendingIntent._send707 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._send708 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V");
			global::android.app.PendingIntent._getService709 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._cancel710 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "cancel", "()V");
			global::android.app.PendingIntent._writeToParcel711 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.PendingIntent._describeContents712 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "describeContents", "()I");
			global::android.app.PendingIntent._getActivity713 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getBroadcast714 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;");
			global::android.app.PendingIntent._getIntentSender715 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "getIntentSender", "()Landroid/content/IntentSender;");
			global::android.app.PendingIntent._getTargetPackage716 = @__env.GetMethodID(global::android.app.PendingIntent.staticClass, "getTargetPackage", "()Ljava/lang/String;");
			global::android.app.PendingIntent._writePendingIntentOrNullToParcel717 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V");
			global::android.app.PendingIntent._readPendingIntentOrNullFromParcel718 = @__env.GetStaticMethodID(global::android.app.PendingIntent.staticClass, "readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;");
		}
	}
}
