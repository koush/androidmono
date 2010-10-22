namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RemoteViews : java.lang.Object, android.os.Parcelable, android.view.LayoutInflater.Filter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RemoteViews()
		{
			InitJNI();
		}
		protected RemoteViews(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ActionException : java.lang.RuntimeException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ActionException()
			{
				InitJNI();
			}
			protected ActionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ActionException17508;
			public ActionException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException17508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _ActionException17509;
			public ActionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException17509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RemoteViews.ActionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews$ActionException"));
				global::android.widget.RemoteViews.ActionException._ActionException17508 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::android.widget.RemoteViews.ActionException._ActionException17509 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RemoteViews.RemoteView_))]
		public partial interface RemoteView : java.lang.annotation.Annotation
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.RemoteViews.RemoteView))]
		public sealed partial class RemoteView_ : java.lang.Object, RemoteView
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static RemoteView_()
			{
				InitJNI();
			}
			internal RemoteView_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals17510;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._equals17510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._equals17510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString17511;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._toString17511)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._toString17511)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode17512;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._hashCode17512);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._hashCode17512);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType17513;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._annotationType17513)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._annotationType17513)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RemoteViews.RemoteView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews$RemoteView"));
				global::android.widget.RemoteViews.RemoteView_._equals17510 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.widget.RemoteViews.RemoteView_._toString17511 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.widget.RemoteViews.RemoteView_._hashCode17512 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "hashCode", "()I");
				global::android.widget.RemoteViews.RemoteView_._annotationType17513 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "annotationType", "()Ljava/lang/Class;");
			}
		}
		public new global::java.lang.String Package
		{
			get
			{
				return getPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage17514;
		public virtual global::java.lang.String getPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews._getPackage17514)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._getPackage17514)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean17515;
		public virtual void setBoolean(int arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setBoolean17515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBoolean17515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setByte17516;
		public virtual void setByte(int arg0, java.lang.String arg1, byte arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setByte17516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setByte17516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setChar17517;
		public virtual void setChar(int arg0, java.lang.String arg1, char arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setChar17517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setChar17517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setShort17518;
		public virtual void setShort(int arg0, java.lang.String arg1, short arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setShort17518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setShort17518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInt17519;
		public virtual void setInt(int arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setInt17519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setInt17519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLong17520;
		public virtual void setLong(int arg0, java.lang.String arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setLong17520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setLong17520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat17521;
		public virtual void setFloat(int arg0, java.lang.String arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setFloat17521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setFloat17521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble17522;
		public virtual void setDouble(int arg0, java.lang.String arg1, double arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setDouble17522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setDouble17522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel17523;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._writeToParcel17523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._writeToParcel17523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents17524;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RemoteViews._describeContents17524);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._describeContents17524);
		}
		internal static global::MonoJavaBridge.MethodId _addView17525;
		public virtual void addView(int arg0, android.widget.RemoteViews arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._addView17525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._addView17525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBitmap17526;
		public virtual void setBitmap(int arg0, java.lang.String arg1, android.graphics.Bitmap arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setBitmap17526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBitmap17526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews17527;
		public virtual void removeAllViews(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._removeAllViews17527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._removeAllViews17527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor17528;
		public virtual void setTextColor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setTextColor17528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setTextColor17528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int LayoutId
		{
			get
			{
				return getLayoutId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutId17529;
		public virtual int getLayoutId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RemoteViews._getLayoutId17529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._getLayoutId17529);
		}
		internal static global::MonoJavaBridge.MethodId _setViewVisibility17530;
		public virtual void setViewVisibility(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setViewVisibility17530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setViewVisibility17530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextViewText17531;
		public virtual void setTextViewText(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setTextViewText17531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setTextViewText17531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextViewText(int arg0, string arg1)
		{
			setTextViewText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewResource17532;
		public virtual void setImageViewResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setImageViewResource17532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewResource17532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewUri17533;
		public virtual void setImageViewUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setImageViewUri17533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewUri17533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewBitmap17534;
		public virtual void setImageViewBitmap(int arg0, android.graphics.Bitmap arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setImageViewBitmap17534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewBitmap17534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChronometer17535;
		public virtual void setChronometer(int arg0, long arg1, java.lang.String arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setChronometer17535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setChronometer17535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBar17536;
		public virtual void setProgressBar(int arg0, int arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setProgressBar17536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setProgressBar17536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickPendingIntent17537;
		public virtual void setOnClickPendingIntent(int arg0, android.app.PendingIntent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setOnClickPendingIntent17537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setOnClickPendingIntent17537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString17538;
		public virtual void setString(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setString17538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setString17538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharSequence17539;
		public virtual void setCharSequence(int arg0, java.lang.String arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setCharSequence17539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setCharSequence17539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setCharSequence(int arg0, java.lang.String arg1, string arg2)
		{
			setCharSequence(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setUri17540;
		public virtual void setUri(int arg0, java.lang.String arg1, android.net.Uri arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setUri17540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setUri17540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBundle17541;
		public virtual void setBundle(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setBundle17541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBundle17541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _apply17542;
		public virtual global::android.view.View apply(android.content.Context arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews._apply17542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._apply17542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _reapply17543;
		public virtual void reapply(android.content.Context arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._reapply17543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._reapply17543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onLoadClass17544;
		public virtual bool onLoadClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews._onLoadClass17544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._onLoadClass17544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RemoteViews17545;
		public RemoteViews(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews17545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RemoteViews17546;
		public RemoteViews(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews17546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR17547;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.widget.RemoteViews.staticClass, _CREATOR17547)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RemoteViews.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews"));
			global::android.widget.RemoteViews._getPackage17514 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "getPackage", "()Ljava/lang/String;");
			global::android.widget.RemoteViews._setBoolean17515 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setBoolean", "(ILjava/lang/String;Z)V");
			global::android.widget.RemoteViews._setByte17516 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setByte", "(ILjava/lang/String;B)V");
			global::android.widget.RemoteViews._setChar17517 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setChar", "(ILjava/lang/String;C)V");
			global::android.widget.RemoteViews._setShort17518 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setShort", "(ILjava/lang/String;S)V");
			global::android.widget.RemoteViews._setInt17519 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setInt", "(ILjava/lang/String;I)V");
			global::android.widget.RemoteViews._setLong17520 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setLong", "(ILjava/lang/String;J)V");
			global::android.widget.RemoteViews._setFloat17521 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setFloat", "(ILjava/lang/String;F)V");
			global::android.widget.RemoteViews._setDouble17522 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setDouble", "(ILjava/lang/String;D)V");
			global::android.widget.RemoteViews._writeToParcel17523 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.widget.RemoteViews._describeContents17524 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "describeContents", "()I");
			global::android.widget.RemoteViews._addView17525 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "addView", "(ILandroid/widget/RemoteViews;)V");
			global::android.widget.RemoteViews._setBitmap17526 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V");
			global::android.widget.RemoteViews._removeAllViews17527 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "removeAllViews", "(I)V");
			global::android.widget.RemoteViews._setTextColor17528 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setTextColor", "(II)V");
			global::android.widget.RemoteViews._getLayoutId17529 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "getLayoutId", "()I");
			global::android.widget.RemoteViews._setViewVisibility17530 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setViewVisibility", "(II)V");
			global::android.widget.RemoteViews._setTextViewText17531 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setTextViewText", "(ILjava/lang/CharSequence;)V");
			global::android.widget.RemoteViews._setImageViewResource17532 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setImageViewResource", "(II)V");
			global::android.widget.RemoteViews._setImageViewUri17533 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setImageViewUri", "(ILandroid/net/Uri;)V");
			global::android.widget.RemoteViews._setImageViewBitmap17534 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V");
			global::android.widget.RemoteViews._setChronometer17535 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setChronometer", "(IJLjava/lang/String;Z)V");
			global::android.widget.RemoteViews._setProgressBar17536 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setProgressBar", "(IIIZ)V");
			global::android.widget.RemoteViews._setOnClickPendingIntent17537 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V");
			global::android.widget.RemoteViews._setString17538 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setString", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::android.widget.RemoteViews._setCharSequence17539 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V");
			global::android.widget.RemoteViews._setUri17540 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setUri", "(ILjava/lang/String;Landroid/net/Uri;)V");
			global::android.widget.RemoteViews._setBundle17541 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setBundle", "(ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.widget.RemoteViews._apply17542 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.RemoteViews._reapply17543 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "reapply", "(Landroid/content/Context;Landroid/view/View;)V");
			global::android.widget.RemoteViews._onLoadClass17544 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z");
			global::android.widget.RemoteViews._RemoteViews17545 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::android.widget.RemoteViews._RemoteViews17546 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.widget.RemoteViews._CREATOR17547 = @__env.GetStaticFieldIDNoThrow(global::android.widget.RemoteViews.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
