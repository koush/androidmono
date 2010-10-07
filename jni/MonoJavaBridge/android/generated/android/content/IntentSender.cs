namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class IntentSender : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static IntentSender()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.IntentSender), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.IntentSender.__OnFinished), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.IntentSender.__OnFinished(@__env);
				}
			}
			internal __OnFinished(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSendFinished1621;
			 void android.content.IntentSender.OnFinished.onSendFinished(android.content.IntentSender arg0, android.content.Intent arg1, int arg2, java.lang.String arg3, android.os.Bundle arg4) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.IntentSender.__OnFinished._onSendFinished1621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentSender.__OnFinished.staticClass, global::android.content.IntentSender.__OnFinished._onSendFinished1621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.IntentSender.__OnFinished.staticClass = @__class;
				global::android.content.IntentSender.__OnFinished._onSendFinished1621 = @__env.GetMethodID(global::android.content.IntentSender.__OnFinished.staticClass, "android.content.IntentSender.OnFinished.onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class SendIntentException : android.util.AndroidException
		{
			internal new static global::java.lang.Class staticClass;
			static SendIntentException()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.IntentSender.SendIntentException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _SendIntentException1622;
			public SendIntentException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException1622, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _SendIntentException1623;
			public SendIntentException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException1623, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _SendIntentException1624;
			public SendIntentException(java.lang.Exception arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.IntentSender.SendIntentException.staticClass, global::android.content.IntentSender.SendIntentException._SendIntentException1624, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.IntentSender.SendIntentException.staticClass = @__class;
				global::android.content.IntentSender.SendIntentException._SendIntentException1622 = @__env.GetMethodID(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "()V");
				global::android.content.IntentSender.SendIntentException._SendIntentException1623 = @__env.GetMethodID(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::android.content.IntentSender.SendIntentException._SendIntentException1624 = @__env.GetMethodID(global::android.content.IntentSender.SendIntentException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1625;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.IntentSender._equals1625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._equals1625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1626;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.IntentSender._toString1626));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._toString1626));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1627;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentSender._hashCode1627);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._hashCode1627);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1628;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentSender._writeToParcel1628, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._writeToParcel1628, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1629;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.IntentSender._describeContents1629);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._describeContents1629);
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendIntent1630;
		public virtual void sendIntent(android.content.Context arg0, int arg1, android.content.Intent arg2, android.content.IntentSender.OnFinished arg3, android.os.Handler arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.IntentSender._sendIntent1630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.IntentSender.staticClass, global::android.content.IntentSender._sendIntent1630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeIntentSenderOrNullToParcel1631;
		public static void writeIntentSenderOrNullToParcel(android.content.IntentSender arg0, android.os.Parcel arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.IntentSender.staticClass, global::android.content.IntentSender._writeIntentSenderOrNullToParcel1631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readIntentSenderOrNullFromParcel1632;
		public static global::android.content.IntentSender readIntentSenderOrNullFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentSender>(@__env, @__env.CallStaticObjectMethodPtr(android.content.IntentSender.staticClass, global::android.content.IntentSender._readIntentSenderOrNullFromParcel1632, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1633;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.IntentSender.staticClass = @__class;
			global::android.content.IntentSender._equals1625 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.IntentSender._toString1626 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.IntentSender._hashCode1627 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "hashCode", "()I");
			global::android.content.IntentSender._writeToParcel1628 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.IntentSender._describeContents1629 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "describeContents", "()I");
			global::android.content.IntentSender._sendIntent1630 = @__env.GetMethodID(global::android.content.IntentSender.staticClass, "sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$OnFinished;Landroid/os/Handler;)V");
			global::android.content.IntentSender._writeIntentSenderOrNullToParcel1631 = @__env.GetStaticMethodID(global::android.content.IntentSender.staticClass, "writeIntentSenderOrNullToParcel", "(Landroid/content/IntentSender;Landroid/os/Parcel;)V");
			global::android.content.IntentSender._readIntentSenderOrNullFromParcel1632 = @__env.GetStaticMethodID(global::android.content.IntentSender.staticClass, "readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;");
		}
	}
}
