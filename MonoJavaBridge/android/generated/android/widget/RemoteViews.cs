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
			internal static global::MonoJavaBridge.MethodId _ActionException17615;
			public ActionException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RemoteViews.ActionException._ActionException17615.native == global::System.IntPtr.Zero)
					global::android.widget.RemoteViews.ActionException._ActionException17615 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException17615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _ActionException17616;
			public ActionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RemoteViews.ActionException._ActionException17616.native == global::System.IntPtr.Zero)
					global::android.widget.RemoteViews.ActionException._ActionException17616 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException17616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _equals17617;
			bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.widget.RemoteViews.RemoteView_._equals17617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString17618;
			global::java.lang.String java.lang.annotation.Annotation.toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.widget.RemoteViews.RemoteView_._toString17618) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode17619;
			int java.lang.annotation.Annotation.hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "hashCode", "()I", ref global::android.widget.RemoteViews.RemoteView_._hashCode17619);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType17620;
			global::java.lang.Class java.lang.annotation.Annotation.annotationType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.widget.RemoteViews.RemoteView_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.widget.RemoteViews.RemoteView_._annotationType17620) as java.lang.Class;
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
		internal static global::MonoJavaBridge.MethodId _getPackage17621;
		public virtual global::java.lang.String getPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.RemoteViews.staticClass, "getPackage", "()Ljava/lang/String;", ref global::android.widget.RemoteViews._getPackage17621) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean17622;
		public virtual void setBoolean(int arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setBoolean", "(ILjava/lang/String;Z)V", ref global::android.widget.RemoteViews._setBoolean17622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setByte17623;
		public virtual void setByte(int arg0, java.lang.String arg1, byte arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setByte", "(ILjava/lang/String;B)V", ref global::android.widget.RemoteViews._setByte17623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setChar17624;
		public virtual void setChar(int arg0, java.lang.String arg1, char arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setChar", "(ILjava/lang/String;C)V", ref global::android.widget.RemoteViews._setChar17624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setShort17625;
		public virtual void setShort(int arg0, java.lang.String arg1, short arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setShort", "(ILjava/lang/String;S)V", ref global::android.widget.RemoteViews._setShort17625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInt17626;
		public virtual void setInt(int arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setInt", "(ILjava/lang/String;I)V", ref global::android.widget.RemoteViews._setInt17626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLong17627;
		public virtual void setLong(int arg0, java.lang.String arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setLong", "(ILjava/lang/String;J)V", ref global::android.widget.RemoteViews._setLong17627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat17628;
		public virtual void setFloat(int arg0, java.lang.String arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setFloat", "(ILjava/lang/String;F)V", ref global::android.widget.RemoteViews._setFloat17628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble17629;
		public virtual void setDouble(int arg0, java.lang.String arg1, double arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setDouble", "(ILjava/lang/String;D)V", ref global::android.widget.RemoteViews._setDouble17629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel17630;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.widget.RemoteViews._writeToParcel17630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents17631;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RemoteViews.staticClass, "describeContents", "()I", ref global::android.widget.RemoteViews._describeContents17631);
		}
		internal static global::MonoJavaBridge.MethodId _addView17632;
		public virtual void addView(int arg0, android.widget.RemoteViews arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "addView", "(ILandroid/widget/RemoteViews;)V", ref global::android.widget.RemoteViews._addView17632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBitmap17633;
		public virtual void setBitmap(int arg0, java.lang.String arg1, android.graphics.Bitmap arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V", ref global::android.widget.RemoteViews._setBitmap17633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews17634;
		public virtual void removeAllViews(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "removeAllViews", "(I)V", ref global::android.widget.RemoteViews._removeAllViews17634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor17635;
		public virtual void setTextColor(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setTextColor", "(II)V", ref global::android.widget.RemoteViews._setTextColor17635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int LayoutId
		{
			get
			{
				return getLayoutId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutId17636;
		public virtual int getLayoutId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RemoteViews.staticClass, "getLayoutId", "()I", ref global::android.widget.RemoteViews._getLayoutId17636);
		}
		internal static global::MonoJavaBridge.MethodId _setViewVisibility17637;
		public virtual void setViewVisibility(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setViewVisibility", "(II)V", ref global::android.widget.RemoteViews._setViewVisibility17637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextViewText17638;
		public virtual void setTextViewText(int arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setTextViewText", "(ILjava/lang/CharSequence;)V", ref global::android.widget.RemoteViews._setTextViewText17638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextViewText(int arg0, string arg1)
		{
			setTextViewText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewResource17639;
		public virtual void setImageViewResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setImageViewResource", "(II)V", ref global::android.widget.RemoteViews._setImageViewResource17639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewUri17640;
		public virtual void setImageViewUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setImageViewUri", "(ILandroid/net/Uri;)V", ref global::android.widget.RemoteViews._setImageViewUri17640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewBitmap17641;
		public virtual void setImageViewBitmap(int arg0, android.graphics.Bitmap arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V", ref global::android.widget.RemoteViews._setImageViewBitmap17641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChronometer17642;
		public virtual void setChronometer(int arg0, long arg1, java.lang.String arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setChronometer", "(IJLjava/lang/String;Z)V", ref global::android.widget.RemoteViews._setChronometer17642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBar17643;
		public virtual void setProgressBar(int arg0, int arg1, int arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setProgressBar", "(IIIZ)V", ref global::android.widget.RemoteViews._setProgressBar17643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickPendingIntent17644;
		public virtual void setOnClickPendingIntent(int arg0, android.app.PendingIntent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V", ref global::android.widget.RemoteViews._setOnClickPendingIntent17644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString17645;
		public virtual void setString(int arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setString", "(ILjava/lang/String;Ljava/lang/String;)V", ref global::android.widget.RemoteViews._setString17645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharSequence17646;
		public virtual void setCharSequence(int arg0, java.lang.String arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V", ref global::android.widget.RemoteViews._setCharSequence17646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setCharSequence(int arg0, java.lang.String arg1, string arg2)
		{
			setCharSequence(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setUri17647;
		public virtual void setUri(int arg0, java.lang.String arg1, android.net.Uri arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setUri", "(ILjava/lang/String;Landroid/net/Uri;)V", ref global::android.widget.RemoteViews._setUri17647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBundle17648;
		public virtual void setBundle(int arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "setBundle", "(ILjava/lang/String;Landroid/os/Bundle;)V", ref global::android.widget.RemoteViews._setBundle17648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _apply17649;
		public virtual global::android.view.View apply(android.content.Context arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RemoteViews.staticClass, "apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.RemoteViews._apply17649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _reapply17650;
		public virtual void reapply(android.content.Context arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RemoteViews.staticClass, "reapply", "(Landroid/content/Context;Landroid/view/View;)V", ref global::android.widget.RemoteViews._reapply17650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onLoadClass17651;
		public virtual bool onLoadClass(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RemoteViews.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z", ref global::android.widget.RemoteViews._onLoadClass17651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RemoteViews17652;
		public RemoteViews(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RemoteViews._RemoteViews17652.native == global::System.IntPtr.Zero)
				global::android.widget.RemoteViews._RemoteViews17652 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews17652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RemoteViews17653;
		public RemoteViews(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RemoteViews._RemoteViews17653.native == global::System.IntPtr.Zero)
				global::android.widget.RemoteViews._RemoteViews17653 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews17653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR17654;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.widget.RemoteViews.staticClass, _CREATOR17654)) as android.os.Parcelable_Creator;
			}
		}
		static RemoteViews()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RemoteViews.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews"));
			global::android.widget.RemoteViews._CREATOR17654 = @__env.GetStaticFieldIDNoThrow(global::android.widget.RemoteViews.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
