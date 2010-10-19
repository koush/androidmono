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
			internal static global::MonoJavaBridge.MethodId _ActionException12323;
			public ActionException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException12323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _ActionException12324;
			public ActionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.ActionException.staticClass, global::android.widget.RemoteViews.ActionException._ActionException12324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RemoteViews.ActionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews$ActionException"));
				global::android.widget.RemoteViews.ActionException._ActionException12323 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::android.widget.RemoteViews.ActionException._ActionException12324 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.ActionException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RemoteViews.RemoteView_))]
		public interface RemoteView : java.lang.annotation.Annotation
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
			internal static global::MonoJavaBridge.MethodId _equals12325;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._equals12325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._equals12325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString12326;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._toString12326)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._toString12326)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode12327;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._hashCode12327);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._hashCode12327);
			}
			internal static global::MonoJavaBridge.MethodId _annotationType12328;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_._annotationType12328)) as java.lang.Class;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.RemoteView_.staticClass, global::android.widget.RemoteViews.RemoteView_._annotationType12328)) as java.lang.Class;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RemoteViews.RemoteView_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews$RemoteView"));
				global::android.widget.RemoteViews.RemoteView_._equals12325 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.widget.RemoteViews.RemoteView_._toString12326 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "toString", "()Ljava/lang/String;");
				global::android.widget.RemoteViews.RemoteView_._hashCode12327 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "hashCode", "()I");
				global::android.widget.RemoteViews.RemoteView_._annotationType12328 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.RemoteView_.staticClass, "annotationType", "()Ljava/lang/Class;");
			}
		}
		public new global::java.lang.String Package
		{
			get
			{
				return getPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage12329;
		public virtual global::java.lang.String getPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews._getPackage12329)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._getPackage12329)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean12330;
		public virtual void setBoolean(int arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setBoolean12330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBoolean12330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setByte12331;
		public virtual void setByte(int arg0, java.lang.String arg1, byte arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setByte12331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setByte12331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setChar12332;
		public virtual void setChar(int arg0, java.lang.String arg1, char arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setChar12332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setChar12332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setShort12333;
		public virtual void setShort(int arg0, java.lang.String arg1, short arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setShort12333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setShort12333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setInt12334;
		public virtual void setInt(int arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setInt12334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setInt12334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setLong12335;
		public virtual void setLong(int arg0, java.lang.String arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setLong12335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setLong12335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat12336;
		public virtual void setFloat(int arg0, java.lang.String arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setFloat12336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setFloat12336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble12337;
		public virtual void setDouble(int arg0, java.lang.String arg1, double arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setDouble12337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setDouble12337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel12338;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._writeToParcel12338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._writeToParcel12338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents12339;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RemoteViews._describeContents12339);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._describeContents12339);
		}
		internal static global::MonoJavaBridge.MethodId _addView12340;
		public virtual void addView(int arg0, android.widget.RemoteViews arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._addView12340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._addView12340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBitmap12341;
		public virtual void setBitmap(int arg0, java.lang.String arg1, android.graphics.Bitmap arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setBitmap12341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBitmap12341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews12342;
		public virtual void removeAllViews(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._removeAllViews12342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._removeAllViews12342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor12343;
		public virtual void setTextColor(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setTextColor12343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setTextColor12343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int LayoutId
		{
			get
			{
				return getLayoutId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutId12344;
		public virtual int getLayoutId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RemoteViews._getLayoutId12344);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._getLayoutId12344);
		}
		internal static global::MonoJavaBridge.MethodId _setViewVisibility12345;
		public virtual void setViewVisibility(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setViewVisibility12345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setViewVisibility12345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextViewText12346;
		public virtual void setTextViewText(int arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setTextViewText12346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setTextViewText12346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextViewText(int arg0, string arg1)
		{
			setTextViewText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewResource12347;
		public virtual void setImageViewResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setImageViewResource12347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewResource12347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewUri12348;
		public virtual void setImageViewUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setImageViewUri12348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewUri12348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageViewBitmap12349;
		public virtual void setImageViewBitmap(int arg0, android.graphics.Bitmap arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setImageViewBitmap12349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setImageViewBitmap12349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChronometer12350;
		public virtual void setChronometer(int arg0, long arg1, java.lang.String arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setChronometer12350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setChronometer12350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressBar12351;
		public virtual void setProgressBar(int arg0, int arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setProgressBar12351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setProgressBar12351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setOnClickPendingIntent12352;
		public virtual void setOnClickPendingIntent(int arg0, android.app.PendingIntent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setOnClickPendingIntent12352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setOnClickPendingIntent12352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString12353;
		public virtual void setString(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setString12353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setString12353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharSequence12354;
		public virtual void setCharSequence(int arg0, java.lang.String arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setCharSequence12354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setCharSequence12354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setCharSequence(int arg0, java.lang.String arg1, string arg2)
		{
			setCharSequence(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setUri12355;
		public virtual void setUri(int arg0, java.lang.String arg1, android.net.Uri arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setUri12355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setUri12355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBundle12356;
		public virtual void setBundle(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._setBundle12356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._setBundle12356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _apply12357;
		public virtual global::android.view.View apply(android.content.Context arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RemoteViews._apply12357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._apply12357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _reapply12358;
		public virtual void reapply(android.content.Context arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RemoteViews._reapply12358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._reapply12358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onLoadClass12359;
		public virtual bool onLoadClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews._onLoadClass12359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._onLoadClass12359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RemoteViews12360;
		public RemoteViews(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews12360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RemoteViews12361;
		public RemoteViews(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RemoteViews.staticClass, global::android.widget.RemoteViews._RemoteViews12361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR12362;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RemoteViews.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RemoteViews"));
			global::android.widget.RemoteViews._getPackage12329 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "getPackage", "()Ljava/lang/String;");
			global::android.widget.RemoteViews._setBoolean12330 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setBoolean", "(ILjava/lang/String;Z)V");
			global::android.widget.RemoteViews._setByte12331 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setByte", "(ILjava/lang/String;B)V");
			global::android.widget.RemoteViews._setChar12332 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setChar", "(ILjava/lang/String;C)V");
			global::android.widget.RemoteViews._setShort12333 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setShort", "(ILjava/lang/String;S)V");
			global::android.widget.RemoteViews._setInt12334 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setInt", "(ILjava/lang/String;I)V");
			global::android.widget.RemoteViews._setLong12335 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setLong", "(ILjava/lang/String;J)V");
			global::android.widget.RemoteViews._setFloat12336 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setFloat", "(ILjava/lang/String;F)V");
			global::android.widget.RemoteViews._setDouble12337 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setDouble", "(ILjava/lang/String;D)V");
			global::android.widget.RemoteViews._writeToParcel12338 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.widget.RemoteViews._describeContents12339 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "describeContents", "()I");
			global::android.widget.RemoteViews._addView12340 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "addView", "(ILandroid/widget/RemoteViews;)V");
			global::android.widget.RemoteViews._setBitmap12341 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V");
			global::android.widget.RemoteViews._removeAllViews12342 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "removeAllViews", "(I)V");
			global::android.widget.RemoteViews._setTextColor12343 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setTextColor", "(II)V");
			global::android.widget.RemoteViews._getLayoutId12344 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "getLayoutId", "()I");
			global::android.widget.RemoteViews._setViewVisibility12345 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setViewVisibility", "(II)V");
			global::android.widget.RemoteViews._setTextViewText12346 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setTextViewText", "(ILjava/lang/CharSequence;)V");
			global::android.widget.RemoteViews._setImageViewResource12347 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setImageViewResource", "(II)V");
			global::android.widget.RemoteViews._setImageViewUri12348 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setImageViewUri", "(ILandroid/net/Uri;)V");
			global::android.widget.RemoteViews._setImageViewBitmap12349 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V");
			global::android.widget.RemoteViews._setChronometer12350 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setChronometer", "(IJLjava/lang/String;Z)V");
			global::android.widget.RemoteViews._setProgressBar12351 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setProgressBar", "(IIIZ)V");
			global::android.widget.RemoteViews._setOnClickPendingIntent12352 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V");
			global::android.widget.RemoteViews._setString12353 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setString", "(ILjava/lang/String;Ljava/lang/String;)V");
			global::android.widget.RemoteViews._setCharSequence12354 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V");
			global::android.widget.RemoteViews._setUri12355 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setUri", "(ILjava/lang/String;Landroid/net/Uri;)V");
			global::android.widget.RemoteViews._setBundle12356 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "setBundle", "(ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.widget.RemoteViews._apply12357 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.RemoteViews._reapply12358 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "reapply", "(Landroid/content/Context;Landroid/view/View;)V");
			global::android.widget.RemoteViews._onLoadClass12359 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z");
			global::android.widget.RemoteViews._RemoteViews12360 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::android.widget.RemoteViews._RemoteViews12361 = @__env.GetMethodIDNoThrow(global::android.widget.RemoteViews.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
