namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextView : android.view.View, android.view.ViewTreeObserver.OnPreDrawListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextView()
		{
			InitJNI();
		}
		protected TextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class BufferType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BufferType()
			{
				InitJNI();
			}
			internal BufferType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values12119;
			public static global::android.widget.TextView.BufferType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._values12119)) as android.widget.TextView.BufferType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf12120;
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._valueOf12120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TextView.BufferType;
			}
			internal static global::MonoJavaBridge.FieldId _EDITABLE12121;
			public static global::android.widget.TextView.BufferType EDITABLE
			{
				get
				{
					return default(global::android.widget.TextView.BufferType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL12122;
			public static global::android.widget.TextView.BufferType NORMAL
			{
				get
				{
					return default(global::android.widget.TextView.BufferType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPANNABLE12123;
			public static global::android.widget.TextView.BufferType SPANNABLE
			{
				get
				{
					return default(global::android.widget.TextView.BufferType);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.BufferType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$BufferType"));
				global::android.widget.TextView.BufferType._values12119 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;");
				global::android.widget.TextView.BufferType._valueOf12120 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TextView.OnEditorActionListener_))]
		public interface OnEditorActionListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TextView.OnEditorActionListener))]
		public sealed partial class OnEditorActionListener_ : java.lang.Object, OnEditorActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnEditorActionListener_()
			{
				InitJNI();
			}
			internal OnEditorActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onEditorAction12124;
			 bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_._onEditorAction12124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_.staticClass, global::android.widget.TextView.OnEditorActionListener_._onEditorAction12124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$OnEditorActionListener"));
				global::android.widget.TextView.OnEditorActionListener_._onEditorAction12124 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.OnEditorActionListener_.staticClass, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SavedState : android.view.View.BaseSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SavedState()
			{
				InitJNI();
			}
			protected SavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString12125;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState._toString12125)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._toString12125)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel12126;
			public override void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState._writeToParcel12126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._writeToParcel12126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR12127;
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
				global::android.widget.TextView.SavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$SavedState"));
				global::android.widget.TextView.SavedState._toString12125 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;");
				global::android.widget.TextView.SavedState._writeToParcel12126 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _append12128;
		public virtual void append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append12128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append12128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void append(string arg0)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append12129;
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append12129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append12129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void append(string arg0, int arg1, int arg2)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _length12130;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._length12130);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._length12130);
		}
		internal static global::MonoJavaBridge.MethodId _debug12131;
		public virtual void debug(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._debug12131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._debug12131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setError12132;
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError12132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError12132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setError(string arg0, android.graphics.drawable.Drawable arg1)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setError12133;
		public virtual void setError(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError12133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError12133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setError(string arg0)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText12134;
		public virtual void setText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText12135;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText12136;
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setText12137;
		public virtual void setText(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setText12138;
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getText12139;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getText12139)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getText12139)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getLayout12140;
		public virtual global::android.text.Layout getLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLayout12140)) as android.text.Layout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLayout12140)) as android.text.Layout;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState12141;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onRestoreInstanceState12141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onRestoreInstanceState12141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState12142;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onSaveInstanceState12142)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSaveInstanceState12142)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown12143;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyDown12143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyDown12143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp12144;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyUp12144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyUp12144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple12145;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyMultiple12145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyMultiple12145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12146;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTouchEvent12146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTouchEvent12146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent12147;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTrackballEvent12147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTrackballEvent12147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged12148;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onWindowFocusChanged12148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onWindowFocusChanged12148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow12149;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onAttachedToWindow12149);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onAttachedToWindow12149);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow12150;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDetachedFromWindow12150);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDetachedFromWindow12150);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent12151;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._dispatchPopulateAccessibilityEvent12151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._dispatchPopulateAccessibilityEvent12151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu12152;
		protected override void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCreateContextMenu12152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateContextMenu12152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity12153;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setGravity12153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setGravity12153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick12154;
		public override bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._performLongClick12154);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._performLongClick12154);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged12155;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFocusChanged12155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFocusChanged12155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach12156;
		public override void onStartTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onStartTemporaryDetach12156);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onStartTemporaryDetach12156);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach12157;
		public override void onFinishTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFinishTemporaryDetach12157);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFinishTemporaryDetach12157);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut12158;
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyShortcut12158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyShortcut12158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor12159;
		public override bool onCheckIsTextEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onCheckIsTextEditor12159);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCheckIsTextEditor12159);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection12160;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onCreateInputConnection12160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateInputConnection12160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress12161;
		public override void cancelLongPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._cancelLongPress12161);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._cancelLongPress12161);
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect12162;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._getFocusedRect12162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFocusedRect12162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll12163;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._computeScroll12163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeScroll12163);
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength12164;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getLeftFadingEdgeStrength12164);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftFadingEdgeStrength12164);
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength12165;
		protected override float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getRightFadingEdgeStrength12165);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightFadingEdgeStrength12165);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange12166;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeHorizontalScrollRange12166);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeHorizontalScrollRange12166);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange12167;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollRange12167);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollRange12167);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent12168;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollExtent12168);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollExtent12168);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw12169;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDraw12169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDraw12169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired12170;
		protected override bool isPaddingOffsetRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isPaddingOffsetRequired12170);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isPaddingOffsetRequired12170);
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset12171;
		protected override int getLeftPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLeftPaddingOffset12171);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftPaddingOffset12171);
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset12172;
		protected override int getRightPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getRightPaddingOffset12172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightPaddingOffset12172);
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset12173;
		protected override int getTopPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTopPaddingOffset12173);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTopPaddingOffset12173);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset12174;
		protected override int getBottomPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBottomPaddingOffset12174);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBottomPaddingOffset12174);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable12175;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._invalidateDrawable12175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._invalidateDrawable12175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable12176;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._verifyDrawable12176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._verifyDrawable12176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged12177;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._drawableStateChanged12177);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._drawableStateChanged12177);
		}
		internal static global::MonoJavaBridge.MethodId _setPadding12178;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPadding12178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPadding12178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSelected12179;
		public override void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelected12179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelected12179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12180;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBaseline12180);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBaseline12180);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12181;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onMeasure12181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onMeasure12181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface12182;
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface12183;
		public virtual void setTypeface(android.graphics.Typeface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface12183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface12183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEditable12184;
		protected virtual bool getDefaultEditable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getDefaultEditable12184);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultEditable12184);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMovementMethod12185;
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getDefaultMovementMethod12185)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultMovementMethod12185)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _getEditableText12186;
		public virtual global::android.text.Editable getEditableText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEditableText12186)) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEditableText12186)) as android.text.Editable;
		}
		internal static global::MonoJavaBridge.MethodId _getLineHeight12187;
		public virtual int getLineHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineHeight12187);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineHeight12187);
		}
		internal static global::MonoJavaBridge.MethodId _getKeyListener12188;
		public virtual global::android.text.method.KeyListener getKeyListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getKeyListener12188)) as android.text.method.KeyListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getKeyListener12188)) as android.text.method.KeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyListener12189;
		public virtual void setKeyListener(android.text.method.KeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setKeyListener12189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setKeyListener12189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMovementMethod12190;
		public virtual global::android.text.method.MovementMethod getMovementMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getMovementMethod12190)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getMovementMethod12190)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setMovementMethod12191;
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMovementMethod12191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMovementMethod12191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransformationMethod12192;
		public virtual global::android.text.method.TransformationMethod getTransformationMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTransformationMethod12192)) as android.text.method.TransformationMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTransformationMethod12192)) as android.text.method.TransformationMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationMethod12193;
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTransformationMethod12193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTransformationMethod12193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingTop12194;
		public virtual int getCompoundPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingTop12194);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingTop12194);
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingBottom12195;
		public virtual int getCompoundPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingBottom12195);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingBottom12195);
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingLeft12196;
		public virtual int getCompoundPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingLeft12196);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingLeft12196);
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingRight12197;
		public virtual int getCompoundPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingRight12197);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingRight12197);
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingTop12198;
		public virtual int getExtendedPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingTop12198);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingTop12198);
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingBottom12199;
		public virtual int getExtendedPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingBottom12199);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingBottom12199);
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingLeft12200;
		public virtual int getTotalPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingLeft12200);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingLeft12200);
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingRight12201;
		public virtual int getTotalPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingRight12201);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingRight12201);
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingTop12202;
		public virtual int getTotalPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingTop12202);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingTop12202);
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingBottom12203;
		public virtual int getTotalPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingBottom12203);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingBottom12203);
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawables12204;
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawables12204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawables12204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds12205;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds12206;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawables12207;
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawables12207)) as android.graphics.drawable.Drawable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawables12207)) as android.graphics.drawable.Drawable[];
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablePadding12208;
		public virtual void setCompoundDrawablePadding(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablePadding12208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablePadding12208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawablePadding12209;
		public virtual int getCompoundDrawablePadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawablePadding12209);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawablePadding12209);
		}
		internal static global::MonoJavaBridge.MethodId _getAutoLinkMask12210;
		public virtual int getAutoLinkMask() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getAutoLinkMask12210);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getAutoLinkMask12210);
		}
		internal static global::MonoJavaBridge.MethodId _setTextAppearance12211;
		public virtual void setTextAppearance(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextAppearance12211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextAppearance12211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize12212;
		public virtual float getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextSize12212);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextSize12212);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize12213;
		public virtual void setTextSize(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize12213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize12213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize12214;
		public virtual void setTextSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize12214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize12214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextScaleX12215;
		public virtual float getTextScaleX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextScaleX12215);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextScaleX12215);
		}
		internal static global::MonoJavaBridge.MethodId _setTextScaleX12216;
		public virtual void setTextScaleX(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextScaleX12216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextScaleX12216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTypeface12217;
		public virtual global::android.graphics.Typeface getTypeface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTypeface12217)) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTypeface12217)) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor12218;
		public virtual void setTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor12218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor12218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor12219;
		public virtual void setTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor12219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor12219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors12220;
		public virtual global::android.content.res.ColorStateList getTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTextColors12220)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors12220)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors12221;
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors12221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTextColor12222;
		public virtual int getCurrentTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentTextColor12222);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentTextColor12222);
		}
		internal static global::MonoJavaBridge.MethodId _setHighlightColor12223;
		public virtual void setHighlightColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHighlightColor12223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHighlightColor12223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShadowLayer12224;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setShadowLayer12224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setShadowLayer12224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getPaint12225;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPaint12225)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaint12225)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _setAutoLinkMask12226;
		public virtual void setAutoLinkMask(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setAutoLinkMask12226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setAutoLinkMask12226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinksClickable12227;
		public virtual void setLinksClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinksClickable12227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinksClickable12227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLinksClickable12228;
		public virtual bool getLinksClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getLinksClickable12228);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinksClickable12228);
		}
		internal static global::MonoJavaBridge.MethodId _getUrls12229;
		public virtual global::android.text.style.URLSpan[] getUrls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getUrls12229)) as android.text.style.URLSpan[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getUrls12229)) as android.text.style.URLSpan[];
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor12230;
		public virtual void setHintTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor12230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor12230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor12231;
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor12231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor12231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHintTextColors12232;
		public virtual global::android.content.res.ColorStateList getHintTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHintTextColors12232)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHintTextColors12232)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentHintTextColor12233;
		public virtual int getCurrentHintTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentHintTextColor12233);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentHintTextColor12233);
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor12234;
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor12234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor12234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor12235;
		public virtual void setLinkTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor12235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor12235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLinkTextColors12236;
		public virtual global::android.content.res.ColorStateList getLinkTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLinkTextColors12236)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinkTextColors12236)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getGravity12237;
		public virtual int getGravity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getGravity12237);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getGravity12237);
		}
		internal static global::MonoJavaBridge.MethodId _getPaintFlags12238;
		public virtual int getPaintFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getPaintFlags12238);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaintFlags12238);
		}
		internal static global::MonoJavaBridge.MethodId _setPaintFlags12239;
		public virtual void setPaintFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPaintFlags12239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPaintFlags12239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontallyScrolling12240;
		public virtual void setHorizontallyScrolling(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHorizontallyScrolling12240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHorizontallyScrolling12240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinLines12241;
		public virtual void setMinLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinLines12241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinLines12241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinHeight12242;
		public virtual void setMinHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinHeight12242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinHeight12242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxLines12243;
		public virtual void setMaxLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxLines12243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxLines12243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight12244;
		public virtual void setMaxHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxHeight12244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxHeight12244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLines12245;
		public virtual void setLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLines12245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLines12245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeight12246;
		public virtual void setHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHeight12246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHeight12246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinEms12247;
		public virtual void setMinEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinEms12247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinEms12247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinWidth12248;
		public virtual void setMinWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinWidth12248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinWidth12248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxEms12249;
		public virtual void setMaxEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxEms12249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxEms12249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth12250;
		public virtual void setMaxWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxWidth12250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxWidth12250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEms12251;
		public virtual void setEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEms12251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEms12251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWidth12252;
		public virtual void setWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setWidth12252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setWidth12252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineSpacing12253;
		public virtual void setLineSpacing(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLineSpacing12253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLineSpacing12253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFreezesText12254;
		public virtual void setFreezesText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFreezesText12254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFreezesText12254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFreezesText12255;
		public virtual bool getFreezesText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getFreezesText12255);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFreezesText12255);
		}
		internal static global::MonoJavaBridge.MethodId _setEditableFactory12256;
		public virtual void setEditableFactory(android.text.Editable_Factory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEditableFactory12256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEditableFactory12256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSpannableFactory12257;
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSpannableFactory12257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSpannableFactory12257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState12258;
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState12258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState12258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextKeepState(string arg0, android.widget.TextView.BufferType arg1)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState12259;
		public virtual void setTextKeepState(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState12259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState12259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextKeepState(string arg0)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint12260;
		public virtual void setHint(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint12260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint12260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setHint(string arg0)
		{
			setHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint12261;
		public virtual void setHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint12261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint12261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHint12262;
		public virtual global::java.lang.CharSequence getHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHint12262)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHint12262)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setInputType12263;
		public virtual void setInputType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputType12263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputType12263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawInputType12264;
		public virtual void setRawInputType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setRawInputType12264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setRawInputType12264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputType12265;
		public virtual int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getInputType12265);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputType12265);
		}
		internal static global::MonoJavaBridge.MethodId _setImeOptions12266;
		public virtual void setImeOptions(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeOptions12266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeOptions12266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getImeOptions12267;
		public virtual int getImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeOptions12267);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeOptions12267);
		}
		internal static global::MonoJavaBridge.MethodId _setImeActionLabel12268;
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeActionLabel12268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeActionLabel12268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setImeActionLabel(string arg0, int arg1)
		{
			setImeActionLabel((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionLabel12269;
		public virtual global::java.lang.CharSequence getImeActionLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getImeActionLabel12269)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionLabel12269)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionId12270;
		public virtual int getImeActionId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeActionId12270);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionId12270);
		}
		internal static global::MonoJavaBridge.MethodId _setOnEditorActionListener12271;
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setOnEditorActionListener12271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setOnEditorActionListener12271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEditorAction12272;
		public virtual void onEditorAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEditorAction12272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEditorAction12272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateImeOptions12273;
		public virtual void setPrivateImeOptions(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPrivateImeOptions12273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPrivateImeOptions12273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateImeOptions12274;
		public virtual global::java.lang.String getPrivateImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPrivateImeOptions12274)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPrivateImeOptions12274)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setInputExtras12275;
		public virtual void setInputExtras(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputExtras12275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputExtras12275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputExtras12276;
		public virtual global::android.os.Bundle getInputExtras(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getInputExtras12276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputExtras12276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getError12277;
		public virtual global::java.lang.CharSequence getError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getError12277)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getError12277)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame12278;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._setFrame12278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFrame12278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setFilters12279;
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFilters12279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFilters12279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilters12280;
		public virtual global::android.text.InputFilter[] getFilters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getFilters12280)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFilters12280)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _onPreDraw12281;
		public virtual bool onPreDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPreDraw12281);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPreDraw12281);
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount12282;
		public virtual int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineCount12282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineCount12282);
		}
		internal static global::MonoJavaBridge.MethodId _getLineBounds12283;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineBounds12283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineBounds12283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extractText12284;
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._extractText12284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._extractText12284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText12285;
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setExtractedText12285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setExtractedText12285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion12286;
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCommitCompletion12286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCommitCompletion12286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit12287;
		public virtual void beginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._beginBatchEdit12287);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._beginBatchEdit12287);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit12288;
		public virtual void endBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._endBatchEdit12288);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._endBatchEdit12288);
		}
		internal static global::MonoJavaBridge.MethodId _onBeginBatchEdit12289;
		public virtual void onBeginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onBeginBatchEdit12289);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onBeginBatchEdit12289);
		}
		internal static global::MonoJavaBridge.MethodId _onEndBatchEdit12290;
		public virtual void onEndBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEndBatchEdit12290);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEndBatchEdit12290);
		}
		internal static global::MonoJavaBridge.MethodId _onPrivateIMECommand12291;
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPrivateIMECommand12291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPrivateIMECommand12291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIncludeFontPadding12292;
		public virtual void setIncludeFontPadding(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setIncludeFontPadding12292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setIncludeFontPadding12292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringPointIntoView12293;
		public virtual bool bringPointIntoView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._bringPointIntoView12293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._bringPointIntoView12293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveCursorToVisibleOffset12294;
		public virtual bool moveCursorToVisibleOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._moveCursorToVisibleOffset12294);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._moveCursorToVisibleOffset12294);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart12295;
		public virtual int getSelectionStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionStart12295);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionStart12295);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd12296;
		public virtual int getSelectionEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionEnd12296);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionEnd12296);
		}
		internal static global::MonoJavaBridge.MethodId _hasSelection12297;
		public virtual bool hasSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._hasSelection12297);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._hasSelection12297);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine12298;
		public virtual void setSingleLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine12298);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine12298);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine12299;
		public virtual void setSingleLine(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine12299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine12299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEllipsize12300;
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEllipsize12300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEllipsize12300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMarqueeRepeatLimit12301;
		public virtual void setMarqueeRepeatLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMarqueeRepeatLimit12301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMarqueeRepeatLimit12301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsize12302;
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEllipsize12302)) as android.text.TextUtils.TruncateAt;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEllipsize12302)) as android.text.TextUtils.TruncateAt;
		}
		internal static global::MonoJavaBridge.MethodId _setSelectAllOnFocus12303;
		public virtual void setSelectAllOnFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelectAllOnFocus12303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelectAllOnFocus12303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorVisible12304;
		public virtual void setCursorVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCursorVisible12304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCursorVisible12304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged12305;
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onTextChanged12305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextChanged12305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged12306;
		protected virtual void onSelectionChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onSelectionChanged12306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSelectionChanged12306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTextChangedListener12307;
		public virtual void addTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._addTextChangedListener12307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._addTextChangedListener12307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeTextChangedListener12308;
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._removeTextChangedListener12308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._removeTextChangedListener12308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearComposingText12309;
		public virtual void clearComposingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._clearComposingText12309);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._clearComposingText12309);
		}
		internal static global::MonoJavaBridge.MethodId _didTouchFocusSelect12310;
		public virtual bool didTouchFocusSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._didTouchFocusSelect12310);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._didTouchFocusSelect12310);
		}
		internal static global::MonoJavaBridge.MethodId _setScroller12311;
		public virtual void setScroller(android.widget.Scroller arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setScroller12311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setScroller12311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextColor12312;
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColor12312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget12313;
		public virtual bool isInputMethodTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isInputMethodTarget12313);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isInputMethodTarget12313);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem12314;
		public virtual bool onTextContextMenuItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTextContextMenuItem12314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextContextMenuItem12314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextView12315;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView12315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView12316;
		public TextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView12316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView12317;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView12317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView"));
			global::android.widget.TextView._append12128 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._append12129 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V");
			global::android.widget.TextView._length12130 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "length", "()I");
			global::android.widget.TextView._debug12131 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "debug", "(I)V");
			global::android.widget.TextView._setError12132 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setError12133 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText12134 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(I)V");
			global::android.widget.TextView._setText12135 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText12136 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setText12137 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "([CII)V");
			global::android.widget.TextView._setText12138 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._getText12139 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getLayout12140 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;");
			global::android.widget.TextView._onRestoreInstanceState12141 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TextView._onSaveInstanceState12142 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TextView._onKeyDown12143 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyUp12144 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyMultiple12145 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onTouchEvent12146 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onTrackballEvent12147 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onWindowFocusChanged12148 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.TextView._onAttachedToWindow12149 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TextView._onDetachedFromWindow12150 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TextView._dispatchPopulateAccessibilityEvent12151 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.TextView._onCreateContextMenu12152 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.widget.TextView._setGravity12153 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setGravity", "(I)V");
			global::android.widget.TextView._performLongClick12154 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "performLongClick", "()Z");
			global::android.widget.TextView._onFocusChanged12155 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.TextView._onStartTemporaryDetach12156 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V");
			global::android.widget.TextView._onFinishTemporaryDetach12157 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.widget.TextView._onKeyShortcut12158 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onCheckIsTextEditor12159 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.widget.TextView._onCreateInputConnection12160 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.TextView._cancelLongPress12161 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "cancelLongPress", "()V");
			global::android.widget.TextView._getFocusedRect12162 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.TextView._computeScroll12163 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeScroll", "()V");
			global::android.widget.TextView._getLeftFadingEdgeStrength12164 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.TextView._getRightFadingEdgeStrength12165 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.TextView._computeHorizontalScrollRange12166 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollRange12167 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollExtent12168 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.TextView._onDraw12169 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TextView._isPaddingOffsetRequired12170 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.widget.TextView._getLeftPaddingOffset12171 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I");
			global::android.widget.TextView._getRightPaddingOffset12172 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I");
			global::android.widget.TextView._getTopPaddingOffset12173 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I");
			global::android.widget.TextView._getBottomPaddingOffset12174 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I");
			global::android.widget.TextView._invalidateDrawable12175 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._verifyDrawable12176 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.TextView._drawableStateChanged12177 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.TextView._setPadding12178 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.TextView._setSelected12179 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelected", "(Z)V");
			global::android.widget.TextView._getBaseline12180 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBaseline", "()I");
			global::android.widget.TextView._onMeasure12181 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onMeasure", "(II)V");
			global::android.widget.TextView._setTypeface12182 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V");
			global::android.widget.TextView._setTypeface12183 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V");
			global::android.widget.TextView._getDefaultEditable12184 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z");
			global::android.widget.TextView._getDefaultMovementMethod12185 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._getEditableText12186 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;");
			global::android.widget.TextView._getLineHeight12187 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineHeight", "()I");
			global::android.widget.TextView._getKeyListener12188 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;");
			global::android.widget.TextView._setKeyListener12189 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V");
			global::android.widget.TextView._getMovementMethod12190 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._setMovementMethod12191 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V");
			global::android.widget.TextView._getTransformationMethod12192 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;");
			global::android.widget.TextView._setTransformationMethod12193 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V");
			global::android.widget.TextView._getCompoundPaddingTop12194 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I");
			global::android.widget.TextView._getCompoundPaddingBottom12195 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I");
			global::android.widget.TextView._getCompoundPaddingLeft12196 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I");
			global::android.widget.TextView._getCompoundPaddingRight12197 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I");
			global::android.widget.TextView._getExtendedPaddingTop12198 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I");
			global::android.widget.TextView._getExtendedPaddingBottom12199 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I");
			global::android.widget.TextView._getTotalPaddingLeft12200 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I");
			global::android.widget.TextView._getTotalPaddingRight12201 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I");
			global::android.widget.TextView._getTotalPaddingTop12202 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I");
			global::android.widget.TextView._getTotalPaddingBottom12203 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I");
			global::android.widget.TextView._setCompoundDrawables12204 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12205 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12206 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V");
			global::android.widget.TextView._getCompoundDrawables12207 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;");
			global::android.widget.TextView._setCompoundDrawablePadding12208 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V");
			global::android.widget.TextView._getCompoundDrawablePadding12209 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I");
			global::android.widget.TextView._getAutoLinkMask12210 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I");
			global::android.widget.TextView._setTextAppearance12211 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V");
			global::android.widget.TextView._getTextSize12212 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextSize", "()F");
			global::android.widget.TextView._setTextSize12213 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(IF)V");
			global::android.widget.TextView._setTextSize12214 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(F)V");
			global::android.widget.TextView._getTextScaleX12215 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextScaleX", "()F");
			global::android.widget.TextView._setTextScaleX12216 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V");
			global::android.widget.TextView._getTypeface12217 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.widget.TextView._setTextColor12218 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(I)V");
			global::android.widget.TextView._setTextColor12219 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getTextColors12220 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getTextColors12221 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentTextColor12222 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I");
			global::android.widget.TextView._setHighlightColor12223 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V");
			global::android.widget.TextView._setShadowLayer12224 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.widget.TextView._getPaint12225 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.widget.TextView._setAutoLinkMask12226 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V");
			global::android.widget.TextView._setLinksClickable12227 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V");
			global::android.widget.TextView._getLinksClickable12228 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinksClickable", "()Z");
			global::android.widget.TextView._getUrls12229 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;");
			global::android.widget.TextView._setHintTextColor12230 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V");
			global::android.widget.TextView._setHintTextColor12231 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getHintTextColors12232 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentHintTextColor12233 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I");
			global::android.widget.TextView._setLinkTextColor12234 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._setLinkTextColor12235 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V");
			global::android.widget.TextView._getLinkTextColors12236 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getGravity12237 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getGravity", "()I");
			global::android.widget.TextView._getPaintFlags12238 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaintFlags", "()I");
			global::android.widget.TextView._setPaintFlags12239 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V");
			global::android.widget.TextView._setHorizontallyScrolling12240 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V");
			global::android.widget.TextView._setMinLines12241 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinLines", "(I)V");
			global::android.widget.TextView._setMinHeight12242 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinHeight", "(I)V");
			global::android.widget.TextView._setMaxLines12243 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxLines", "(I)V");
			global::android.widget.TextView._setMaxHeight12244 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.TextView._setLines12245 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLines", "(I)V");
			global::android.widget.TextView._setHeight12246 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHeight", "(I)V");
			global::android.widget.TextView._setMinEms12247 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinEms", "(I)V");
			global::android.widget.TextView._setMinWidth12248 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinWidth", "(I)V");
			global::android.widget.TextView._setMaxEms12249 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxEms", "(I)V");
			global::android.widget.TextView._setMaxWidth12250 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.TextView._setEms12251 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEms", "(I)V");
			global::android.widget.TextView._setWidth12252 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setWidth", "(I)V");
			global::android.widget.TextView._setLineSpacing12253 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V");
			global::android.widget.TextView._setFreezesText12254 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V");
			global::android.widget.TextView._getFreezesText12255 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFreezesText", "()Z");
			global::android.widget.TextView._setEditableFactory12256 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V");
			global::android.widget.TextView._setSpannableFactory12257 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V");
			global::android.widget.TextView._setTextKeepState12258 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setTextKeepState12259 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint12260 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint12261 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(I)V");
			global::android.widget.TextView._getHint12262 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setInputType12263 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputType", "(I)V");
			global::android.widget.TextView._setRawInputType12264 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setRawInputType", "(I)V");
			global::android.widget.TextView._getInputType12265 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputType", "()I");
			global::android.widget.TextView._setImeOptions12266 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeOptions", "(I)V");
			global::android.widget.TextView._getImeOptions12267 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeOptions", "()I");
			global::android.widget.TextView._setImeActionLabel12268 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.TextView._getImeActionLabel12269 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getImeActionId12270 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionId", "()I");
			global::android.widget.TextView._setOnEditorActionListener12271 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V");
			global::android.widget.TextView._onEditorAction12272 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEditorAction", "(I)V");
			global::android.widget.TextView._setPrivateImeOptions12273 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V");
			global::android.widget.TextView._getPrivateImeOptions12274 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;");
			global::android.widget.TextView._setInputExtras12275 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputExtras", "(I)V");
			global::android.widget.TextView._getInputExtras12276 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;");
			global::android.widget.TextView._getError12277 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setFrame12278 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.TextView._setFilters12279 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.widget.TextView._getFilters12280 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.widget.TextView._onPreDraw12281 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPreDraw", "()Z");
			global::android.widget.TextView._getLineCount12282 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineCount", "()I");
			global::android.widget.TextView._getLineBounds12283 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.widget.TextView._extractText12284 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z");
			global::android.widget.TextView._setExtractedText12285 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.widget.TextView._onCommitCompletion12286 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.TextView._beginBatchEdit12287 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "beginBatchEdit", "()V");
			global::android.widget.TextView._endBatchEdit12288 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "endBatchEdit", "()V");
			global::android.widget.TextView._onBeginBatchEdit12289 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V");
			global::android.widget.TextView._onEndBatchEdit12290 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V");
			global::android.widget.TextView._onPrivateIMECommand12291 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.widget.TextView._setIncludeFontPadding12292 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V");
			global::android.widget.TextView._bringPointIntoView12293 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z");
			global::android.widget.TextView._moveCursorToVisibleOffset12294 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z");
			global::android.widget.TextView._getSelectionStart12295 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionStart", "()I");
			global::android.widget.TextView._getSelectionEnd12296 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionEnd", "()I");
			global::android.widget.TextView._hasSelection12297 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "hasSelection", "()Z");
			global::android.widget.TextView._setSingleLine12298 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "()V");
			global::android.widget.TextView._setSingleLine12299 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V");
			global::android.widget.TextView._setEllipsize12300 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V");
			global::android.widget.TextView._setMarqueeRepeatLimit12301 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V");
			global::android.widget.TextView._getEllipsize12302 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;");
			global::android.widget.TextView._setSelectAllOnFocus12303 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V");
			global::android.widget.TextView._setCursorVisible12304 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V");
			global::android.widget.TextView._onTextChanged12305 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.TextView._onSelectionChanged12306 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V");
			global::android.widget.TextView._addTextChangedListener12307 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._removeTextChangedListener12308 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._clearComposingText12309 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "clearComposingText", "()V");
			global::android.widget.TextView._didTouchFocusSelect12310 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z");
			global::android.widget.TextView._setScroller12311 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V");
			global::android.widget.TextView._getTextColor12312 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I");
			global::android.widget.TextView._isInputMethodTarget12313 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z");
			global::android.widget.TextView._onTextContextMenuItem12314 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.widget.TextView._TextView12315 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TextView._TextView12316 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TextView._TextView12317 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
