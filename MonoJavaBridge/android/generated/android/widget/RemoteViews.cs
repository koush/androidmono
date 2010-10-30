namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RemoteViews : java.lang.Object, android.os.Parcelable, android.view.LayoutInflater.Filter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RemoteViews(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ActionException : java.lang.RuntimeException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ActionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ActionException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RemoteViews.ActionException._m0.native == global::System.IntPtr.Zero)
					global::android.widget.RemoteViews.ActionException._m0 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public ActionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RemoteViews.ActionException._m1.native == global::System.IntPtr.Zero)
					global::android.widget.RemoteViews.ActionException._m1 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static ActionException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RemoteViews.ActionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews$ActionException"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RemoteViews.RemoteView_))]
		public partial interface RemoteView : java.lang.annotation.Annotation
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.RemoteViews.RemoteView))]
		internal sealed partial class RemoteView_ : java.lang.Object, RemoteView
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal RemoteView_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.widget.RemoteViews.RemoteView_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.widget.RemoteViews.RemoteView_._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "hashCode", "()I", ref global::android.widget.RemoteViews.RemoteView_._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.widget.RemoteViews.RemoteView_._m3) as java.lang.Class;
			}
			static RemoteView_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RemoteViews.RemoteView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews$RemoteView"));
			}
			internal static void InitJNI()
			{
			}
		}
		public new global::java.lang.String Package
		{
			get
			{
				return getPackage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.RemoteViews.staticClass, "getPackage", "()Ljava/lang/String;", ref global::android.widget.RemoteViews._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setBoolean(int arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setBoolean", "(ILjava/lang/String;Z)V", ref global::android.widget.RemoteViews._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setByte(int arg0, java.lang.String arg1, byte arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setByte", "(ILjava/lang/String;B)V", ref global::android.widget.RemoteViews._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setChar(int arg0, java.lang.String arg1, char arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setChar", "(ILjava/lang/String;C)V", ref global::android.widget.RemoteViews._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setShort(int arg0, java.lang.String arg1, short arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setShort", "(ILjava/lang/String;S)V", ref global::android.widget.RemoteViews._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setInt(int arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setInt", "(ILjava/lang/String;I)V", ref global::android.widget.RemoteViews._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setLong(int arg0, java.lang.String arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setLong", "(ILjava/lang/String;J)V", ref global::android.widget.RemoteViews._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setFloat(int arg0, java.lang.String arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setFloat", "(ILjava/lang/String;F)V", ref global::android.widget.RemoteViews._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setDouble(int arg0, java.lang.String arg1, double arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setDouble", "(ILjava/lang/String;D)V", ref global::android.widget.RemoteViews._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.widget.RemoteViews._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RemoteViews.staticClass, "describeContents", "()I", ref global::android.widget.RemoteViews._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void addView(int arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "addView", "(ILandroid/widget/RemoteViews;)V", ref global::android.widget.RemoteViews._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setBitmap(int arg0, java.lang.String arg1, android.graphics.Bitmap arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V", ref global::android.widget.RemoteViews._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void removeAllViews(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "removeAllViews", "(I)V", ref global::android.widget.RemoteViews._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setTextColor(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setTextColor", "(II)V", ref global::android.widget.RemoteViews._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int LayoutId
		{
			get
			{
				return getLayoutId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getLayoutId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RemoteViews.staticClass, "getLayoutId", "()I", ref global::android.widget.RemoteViews._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setViewVisibility(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setViewVisibility", "(II)V", ref global::android.widget.RemoteViews._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setTextViewText(int arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setTextViewText", "(ILjava/lang/CharSequence;)V", ref global::android.widget.RemoteViews._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextViewText(int arg0, string arg1)
		{
			setTextViewText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setImageViewResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setImageViewResource", "(II)V", ref global::android.widget.RemoteViews._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setImageViewUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setImageViewUri", "(ILandroid/net/Uri;)V", ref global::android.widget.RemoteViews._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setImageViewBitmap(int arg0, android.graphics.Bitmap arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V", ref global::android.widget.RemoteViews._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setChronometer(int arg0, long arg1, java.lang.String arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setChronometer", "(IJLjava/lang/String;Z)V", ref global::android.widget.RemoteViews._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setProgressBar(int arg0, int arg1, int arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setProgressBar", "(IIIZ)V", ref global::android.widget.RemoteViews._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setOnClickPendingIntent(int arg0, android.app.PendingIntent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V", ref global::android.widget.RemoteViews._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setString(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setString", "(ILjava/lang/String;Ljava/lang/String;)V", ref global::android.widget.RemoteViews._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setCharSequence(int arg0, java.lang.String arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V", ref global::android.widget.RemoteViews._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setCharSequence(int arg0, java.lang.String arg1, string arg2)
		{
			setCharSequence(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setUri(int arg0, java.lang.String arg1, android.net.Uri arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setUri", "(ILjava/lang/String;Landroid/net/Uri;)V", ref global::android.widget.RemoteViews._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setBundle(int arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setBundle", "(ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.widget.RemoteViews._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::android.view.View apply(android.content.Context arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RemoteViews.staticClass, "apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.RemoteViews._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void reapply(android.content.Context arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "reapply", "(Landroid/content/Context;Landroid/view/View;)V", ref global::android.widget.RemoteViews._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool onLoadClass(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RemoteViews.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z", ref global::android.widget.RemoteViews._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public RemoteViews(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RemoteViews._m31.native == global::System.IntPtr.Zero)
				global::android.widget.RemoteViews._m31 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public RemoteViews(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RemoteViews._m32.native == global::System.IntPtr.Zero)
				global::android.widget.RemoteViews._m32 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6102;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.widget.RemoteViews.staticClass, _CREATOR6102)) as android.os.Parcelable_Creator;
			}
		}
		static RemoteViews()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RemoteViews.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews"));
			global::android.widget.RemoteViews._CREATOR6102 = @__env.GetStaticFieldIDNoThrow(global::android.widget.RemoteViews.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
