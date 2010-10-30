namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextView : android.view.View, android.view.ViewTreeObserver.OnPreDrawListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class BufferType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal BufferType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values17967;
			public static global::android.widget.TextView.BufferType[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TextView.BufferType._values17967.native == global::System.IntPtr.Zero)
					global::android.widget.TextView.BufferType._values17967 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._values17967)) as android.widget.TextView.BufferType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf17968;
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TextView.BufferType._valueOf17968.native == global::System.IntPtr.Zero)
					global::android.widget.TextView.BufferType._valueOf17968 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._valueOf17968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TextView.BufferType;
			}
			internal static global::MonoJavaBridge.FieldId _EDITABLE17969;
			public static global::android.widget.TextView.BufferType EDITABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _EDITABLE17969)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL17970;
			public static global::android.widget.TextView.BufferType NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _NORMAL17970)) as android.widget.TextView.BufferType;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPANNABLE17971;
			public static global::android.widget.TextView.BufferType SPANNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.widget.TextView.BufferType>(@__env.GetStaticObjectField(global::android.widget.TextView.BufferType.staticClass, _SPANNABLE17971)) as android.widget.TextView.BufferType;
				}
			}
			static BufferType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.BufferType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$BufferType"));
				global::android.widget.TextView.BufferType._EDITABLE17969 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "EDITABLE", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._NORMAL17970 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "NORMAL", "Landroid/widget/TextView$BufferType;");
				global::android.widget.TextView.BufferType._SPANNABLE17971 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "SPANNABLE", "Landroid/widget/TextView$BufferType;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.TextView.OnEditorActionListener_))]
		public partial interface OnEditorActionListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.TextView.OnEditorActionListener))]
		internal sealed partial class OnEditorActionListener_ : java.lang.Object, OnEditorActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnEditorActionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onEditorAction17972;
			bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.OnEditorActionListener_.staticClass, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView.OnEditorActionListener_._onEditorAction17972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnEditorActionListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$OnEditorActionListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnEditorActionListenerDelegate(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2);

		internal partial class OnEditorActionListenerDelegateWrapper : java.lang.Object, OnEditorActionListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnEditorActionListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnEditorActionListenerDelegateWrapper17973;
			public OnEditorActionListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._OnEditorActionListenerDelegateWrapper17973.native == global::System.IntPtr.Zero)
					global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._OnEditorActionListenerDelegateWrapper17973 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass, global::android.widget.TextView.OnEditorActionListenerDelegateWrapper._OnEditorActionListenerDelegateWrapper17973);
				Init(@__env, handle);
			}
			static OnEditorActionListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView_OnEditorActionListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnEditorActionListenerDelegateWrapper
		{
			private OnEditorActionListenerDelegate myDelegate;
			public bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnEditorActionListenerDelegateWrapper(OnEditorActionListenerDelegate d)
			{
				global::android.widget.TextView.OnEditorActionListenerDelegateWrapper ret = new global::android.widget.TextView.OnEditorActionListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SavedState : android.view.View.BaseSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString17974;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;", ref global::android.widget.TextView.SavedState._toString17974) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel17975;
			public override void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.widget.TextView.SavedState._writeToParcel17975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR17976;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.widget.TextView.SavedState.staticClass, _CREATOR17976)) as android.os.Parcelable_Creator;
				}
			}
			static SavedState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.SavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$SavedState"));
				global::android.widget.TextView.SavedState._CREATOR17976 = @__env.GetStaticFieldIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _append17977;
		public virtual void append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._append17977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void append(string arg0)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append17978;
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V", ref global::android.widget.TextView._append17978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void append(string arg0, int arg1, int arg2)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _length17979;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "length", "()I", ref global::android.widget.TextView._length17979);
		}
		internal static global::MonoJavaBridge.MethodId _debug17980;
		public virtual void debug(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "debug", "(I)V", ref global::android.widget.TextView._debug17980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setError17981;
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._setError17981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setError(string arg0, android.graphics.drawable.Drawable arg1)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setError17982;
		public virtual void setError(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._setError17982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setError(string arg0)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText17983;
		public virtual void setText(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(I)V", ref global::android.widget.TextView._setText17983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText17984;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._setText17984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText17985;
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", ref global::android.widget.TextView._setText17985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setText17986;
		public virtual void setText(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "([CII)V", ref global::android.widget.TextView._setText17986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setText17987;
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V", ref global::android.widget.TextView._setText17987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new string Text
		{
			get
			{
				return getText().toString();
			}
			set
			{
				setText((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getText17988;
		public virtual global::java.lang.CharSequence getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._getText17988) as java.lang.CharSequence;
		}
		public new global::android.text.Layout Layout
		{
			get
			{
				return getLayout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayout17989;
		public virtual global::android.text.Layout getLayout()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;", ref global::android.widget.TextView._getLayout17989) as android.text.Layout;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17990;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.TextView._onRestoreInstanceState17990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17991;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.TextView._onSaveInstanceState17991) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17992;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._onKeyDown17992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17993;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._onKeyUp17993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple17994;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._onKeyMultiple17994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent17995;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.TextView._onTouchEvent17995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent17996;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.TextView._onTrackballEvent17996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged17997;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.widget.TextView._onWindowFocusChanged17997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow17998;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.TextView._onAttachedToWindow17998);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow17999;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.TextView._onDetachedFromWindow17999);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent18000;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.widget.TextView._dispatchPopulateAccessibilityEvent18000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu18001;
		protected override void onCreateContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V", ref global::android.widget.TextView._onCreateContextMenu18001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity18002;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setGravity", "(I)V", ref global::android.widget.TextView._setGravity18002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick18003;
		public override bool performLongClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "performLongClick", "()Z", ref global::android.widget.TextView._performLongClick18003);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged18004;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.TextView._onFocusChanged18004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach18005;
		public override void onStartTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V", ref global::android.widget.TextView._onStartTemporaryDetach18005);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach18006;
		public override void onFinishTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V", ref global::android.widget.TextView._onFinishTemporaryDetach18006);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut18007;
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.TextView._onKeyShortcut18007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor18008;
		public override bool onCheckIsTextEditor()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z", ref global::android.widget.TextView._onCheckIsTextEditor18008);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection18009;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;", ref global::android.widget.TextView._onCreateInputConnection18009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress18010;
		public override void cancelLongPress()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "cancelLongPress", "()V", ref global::android.widget.TextView._cancelLongPress18010);
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect18011;
		public override void getFocusedRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V", ref global::android.widget.TextView._getFocusedRect18011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll18012;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "computeScroll", "()V", ref global::android.widget.TextView._computeScroll18012);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength18013;
		protected override float getLeftFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F", ref global::android.widget.TextView._getLeftFadingEdgeStrength18013);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength18014;
		protected override float getRightFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F", ref global::android.widget.TextView._getRightFadingEdgeStrength18014);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange18015;
		protected override int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I", ref global::android.widget.TextView._computeHorizontalScrollRange18015);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange18016;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I", ref global::android.widget.TextView._computeVerticalScrollRange18016);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent18017;
		protected override int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.widget.TextView._computeVerticalScrollExtent18017);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw18018;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.TextView._onDraw18018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired18019;
		protected override bool isPaddingOffsetRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z", ref global::android.widget.TextView._isPaddingOffsetRequired18019);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset18020;
		protected override int getLeftPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I", ref global::android.widget.TextView._getLeftPaddingOffset18020);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset18021;
		protected override int getRightPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I", ref global::android.widget.TextView._getRightPaddingOffset18021);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset18022;
		protected override int getTopPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I", ref global::android.widget.TextView._getTopPaddingOffset18022);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset18023;
		protected override int getBottomPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I", ref global::android.widget.TextView._getBottomPaddingOffset18023);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable18024;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._invalidateDrawable18024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable18025;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.TextView._verifyDrawable18025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged18026;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "drawableStateChanged", "()V", ref global::android.widget.TextView._drawableStateChanged18026);
		}
		internal static global::MonoJavaBridge.MethodId _setPadding18027;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setPadding", "(IIII)V", ref global::android.widget.TextView._setPadding18027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new bool Selected
		{
			set
			{
				setSelected(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelected18028;
		public override void setSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSelected", "(Z)V", ref global::android.widget.TextView._setSelected18028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline18029;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getBaseline", "()I", ref global::android.widget.TextView._getBaseline18029);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure18030;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onMeasure", "(II)V", ref global::android.widget.TextView._onMeasure18030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface18031;
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V", ref global::android.widget.TextView._setTypeface18031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface18032;
		public virtual void setTypeface(android.graphics.Typeface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V", ref global::android.widget.TextView._setTypeface18032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEditable18033;
		protected virtual bool getDefaultEditable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z", ref global::android.widget.TextView._getDefaultEditable18033);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMovementMethod18034;
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.MovementMethod>(this, global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", ref global::android.widget.TextView._getDefaultMovementMethod18034) as android.text.method.MovementMethod;
		}
		public new global::android.text.Editable EditableText
		{
			get
			{
				return getEditableText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditableText18035;
		public virtual global::android.text.Editable getEditableText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.Editable>(this, global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;", ref global::android.widget.TextView._getEditableText18035) as android.text.Editable;
		}
		public new int LineHeight
		{
			get
			{
				return getLineHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineHeight18036;
		public virtual int getLineHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLineHeight", "()I", ref global::android.widget.TextView._getLineHeight18036);
		}
		public new global::android.text.method.KeyListener KeyListener
		{
			get
			{
				return getKeyListener();
			}
			set
			{
				setKeyListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeyListener18037;
		public virtual global::android.text.method.KeyListener getKeyListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.KeyListener>(this, global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;", ref global::android.widget.TextView._getKeyListener18037) as android.text.method.KeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyListener18038;
		public virtual void setKeyListener(android.text.method.KeyListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V", ref global::android.widget.TextView._setKeyListener18038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.method.MovementMethod MovementMethod
		{
			get
			{
				return getMovementMethod();
			}
			set
			{
				setMovementMethod(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMovementMethod18039;
		public virtual global::android.text.method.MovementMethod getMovementMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.MovementMethod>(this, global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;", ref global::android.widget.TextView._getMovementMethod18039) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setMovementMethod18040;
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V", ref global::android.widget.TextView._setMovementMethod18040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.method.TransformationMethod TransformationMethod
		{
			get
			{
				return getTransformationMethod();
			}
			set
			{
				setTransformationMethod(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTransformationMethod18041;
		public virtual global::android.text.method.TransformationMethod getTransformationMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.text.method.TransformationMethod>(this, global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;", ref global::android.widget.TextView._getTransformationMethod18041) as android.text.method.TransformationMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationMethod18042;
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V", ref global::android.widget.TextView._setTransformationMethod18042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CompoundPaddingTop
		{
			get
			{
				return getCompoundPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingTop18043;
		public virtual int getCompoundPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I", ref global::android.widget.TextView._getCompoundPaddingTop18043);
		}
		public new int CompoundPaddingBottom
		{
			get
			{
				return getCompoundPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingBottom18044;
		public virtual int getCompoundPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I", ref global::android.widget.TextView._getCompoundPaddingBottom18044);
		}
		public new int CompoundPaddingLeft
		{
			get
			{
				return getCompoundPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingLeft18045;
		public virtual int getCompoundPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I", ref global::android.widget.TextView._getCompoundPaddingLeft18045);
		}
		public new int CompoundPaddingRight
		{
			get
			{
				return getCompoundPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingRight18046;
		public virtual int getCompoundPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I", ref global::android.widget.TextView._getCompoundPaddingRight18046);
		}
		public new int ExtendedPaddingTop
		{
			get
			{
				return getExtendedPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingTop18047;
		public virtual int getExtendedPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I", ref global::android.widget.TextView._getExtendedPaddingTop18047);
		}
		public new int ExtendedPaddingBottom
		{
			get
			{
				return getExtendedPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingBottom18048;
		public virtual int getExtendedPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I", ref global::android.widget.TextView._getExtendedPaddingBottom18048);
		}
		public new int TotalPaddingLeft
		{
			get
			{
				return getTotalPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingLeft18049;
		public virtual int getTotalPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I", ref global::android.widget.TextView._getTotalPaddingLeft18049);
		}
		public new int TotalPaddingRight
		{
			get
			{
				return getTotalPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingRight18050;
		public virtual int getTotalPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I", ref global::android.widget.TextView._getTotalPaddingRight18050);
		}
		public new int TotalPaddingTop
		{
			get
			{
				return getTotalPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingTop18051;
		public virtual int getTotalPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I", ref global::android.widget.TextView._getTotalPaddingTop18051);
		}
		public new int TotalPaddingBottom
		{
			get
			{
				return getTotalPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingBottom18052;
		public virtual int getTotalPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I", ref global::android.widget.TextView._getTotalPaddingBottom18052);
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawables18053;
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._setCompoundDrawables18053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds18054;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds18055;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V", ref global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds18055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.drawable.Drawable[] CompoundDrawables
		{
			get
			{
				return getCompoundDrawables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawables18056;
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.graphics.drawable.Drawable>(this, global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;", ref global::android.widget.TextView._getCompoundDrawables18056) as android.graphics.drawable.Drawable[];
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablePadding18057;
		public virtual void setCompoundDrawablePadding(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V", ref global::android.widget.TextView._setCompoundDrawablePadding18057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CompoundDrawablePadding
		{
			get
			{
				return getCompoundDrawablePadding();
			}
			set
			{
				setCompoundDrawablePadding(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawablePadding18058;
		public virtual int getCompoundDrawablePadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I", ref global::android.widget.TextView._getCompoundDrawablePadding18058);
		}
		public new int AutoLinkMask
		{
			get
			{
				return getAutoLinkMask();
			}
			set
			{
				setAutoLinkMask(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAutoLinkMask18059;
		public virtual int getAutoLinkMask()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I", ref global::android.widget.TextView._getAutoLinkMask18059);
		}
		internal static global::MonoJavaBridge.MethodId _setTextAppearance18060;
		public virtual void setTextAppearance(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V", ref global::android.widget.TextView._setTextAppearance18060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float TextSize
		{
			get
			{
				return getTextSize();
			}
			set
			{
				setTextSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextSize18061;
		public virtual float getTextSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getTextSize", "()F", ref global::android.widget.TextView._getTextSize18061);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize18062;
		public virtual void setTextSize(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextSize", "(IF)V", ref global::android.widget.TextView._setTextSize18062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize18063;
		public virtual void setTextSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextSize", "(F)V", ref global::android.widget.TextView._setTextSize18063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float TextScaleX
		{
			get
			{
				return getTextScaleX();
			}
			set
			{
				setTextScaleX(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextScaleX18064;
		public virtual float getTextScaleX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.TextView.staticClass, "getTextScaleX", "()F", ref global::android.widget.TextView._getTextScaleX18064);
		}
		internal static global::MonoJavaBridge.MethodId _setTextScaleX18065;
		public virtual void setTextScaleX(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V", ref global::android.widget.TextView._setTextScaleX18065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Typeface Typeface
		{
			get
			{
				return getTypeface();
			}
			set
			{
				setTypeface(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeface18066;
		public virtual global::android.graphics.Typeface getTypeface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;", ref global::android.widget.TextView._getTypeface18066) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor18067;
		public virtual void setTextColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextColor", "(I)V", ref global::android.widget.TextView._setTextColor18067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor18068;
		public virtual void setTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V", ref global::android.widget.TextView._setTextColor18068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList TextColors
		{
			get
			{
				return getTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors18069;
		public virtual global::android.content.res.ColorStateList getTextColors()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;", ref global::android.widget.TextView._getTextColors18069) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors18070;
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._getTextColors18070.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._getTextColors18070 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors18070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		public new int CurrentTextColor
		{
			get
			{
				return getCurrentTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTextColor18071;
		public virtual int getCurrentTextColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I", ref global::android.widget.TextView._getCurrentTextColor18071);
		}
		public new int HighlightColor
		{
			set
			{
				setHighlightColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHighlightColor18072;
		public virtual void setHighlightColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V", ref global::android.widget.TextView._setHighlightColor18072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShadowLayer18073;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V", ref global::android.widget.TextView._setShadowLayer18073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.text.TextPaint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint18074;
		public virtual global::android.text.TextPaint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;", ref global::android.widget.TextView._getPaint18074) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _setAutoLinkMask18075;
		public virtual void setAutoLinkMask(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V", ref global::android.widget.TextView._setAutoLinkMask18075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinksClickable18076;
		public virtual void setLinksClickable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V", ref global::android.widget.TextView._setLinksClickable18076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LinksClickable
		{
			get
			{
				return getLinksClickable();
			}
			set
			{
				setLinksClickable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinksClickable18077;
		public virtual bool getLinksClickable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "getLinksClickable", "()Z", ref global::android.widget.TextView._getLinksClickable18077);
		}
		public new global::android.text.style.URLSpan[] Urls
		{
			get
			{
				return getUrls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrls18078;
		public virtual global::android.text.style.URLSpan[] getUrls()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.text.style.URLSpan>(this, global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;", ref global::android.widget.TextView._getUrls18078) as android.text.style.URLSpan[];
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor18079;
		public virtual void setHintTextColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V", ref global::android.widget.TextView._setHintTextColor18079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor18080;
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V", ref global::android.widget.TextView._setHintTextColor18080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList HintTextColors
		{
			get
			{
				return getHintTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHintTextColors18081;
		public virtual global::android.content.res.ColorStateList getHintTextColors()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;", ref global::android.widget.TextView._getHintTextColors18081) as android.content.res.ColorStateList;
		}
		public new int CurrentHintTextColor
		{
			get
			{
				return getCurrentHintTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentHintTextColor18082;
		public virtual int getCurrentHintTextColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I", ref global::android.widget.TextView._getCurrentHintTextColor18082);
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor18083;
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V", ref global::android.widget.TextView._setLinkTextColor18083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor18084;
		public virtual void setLinkTextColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V", ref global::android.widget.TextView._setLinkTextColor18084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList LinkTextColors
		{
			get
			{
				return getLinkTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinkTextColors18085;
		public virtual global::android.content.res.ColorStateList getLinkTextColors()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;", ref global::android.widget.TextView._getLinkTextColors18085) as android.content.res.ColorStateList;
		}
		public new int Gravity
		{
			get
			{
				return getGravity();
			}
			set
			{
				setGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGravity18086;
		public virtual int getGravity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getGravity", "()I", ref global::android.widget.TextView._getGravity18086);
		}
		public new int PaintFlags
		{
			get
			{
				return getPaintFlags();
			}
			set
			{
				setPaintFlags(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaintFlags18087;
		public virtual int getPaintFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getPaintFlags", "()I", ref global::android.widget.TextView._getPaintFlags18087);
		}
		internal static global::MonoJavaBridge.MethodId _setPaintFlags18088;
		public virtual void setPaintFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V", ref global::android.widget.TextView._setPaintFlags18088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool HorizontallyScrolling
		{
			set
			{
				setHorizontallyScrolling(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontallyScrolling18089;
		public virtual void setHorizontallyScrolling(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V", ref global::android.widget.TextView._setHorizontallyScrolling18089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinLines
		{
			set
			{
				setMinLines(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinLines18090;
		public virtual void setMinLines(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinLines", "(I)V", ref global::android.widget.TextView._setMinLines18090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinHeight
		{
			set
			{
				setMinHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinHeight18091;
		public virtual void setMinHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinHeight", "(I)V", ref global::android.widget.TextView._setMinHeight18091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxLines
		{
			set
			{
				setMaxLines(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxLines18092;
		public virtual void setMaxLines(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxLines", "(I)V", ref global::android.widget.TextView._setMaxLines18092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxHeight
		{
			set
			{
				setMaxHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight18093;
		public virtual void setMaxHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V", ref global::android.widget.TextView._setMaxHeight18093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Lines
		{
			set
			{
				setLines(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLines18094;
		public virtual void setLines(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLines", "(I)V", ref global::android.widget.TextView._setLines18094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Height
		{
			set
			{
				setHeight(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHeight18095;
		public virtual void setHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHeight", "(I)V", ref global::android.widget.TextView._setHeight18095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinEms
		{
			set
			{
				setMinEms(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinEms18096;
		public virtual void setMinEms(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinEms", "(I)V", ref global::android.widget.TextView._setMinEms18096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinWidth
		{
			set
			{
				setMinWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMinWidth18097;
		public virtual void setMinWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMinWidth", "(I)V", ref global::android.widget.TextView._setMinWidth18097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxEms
		{
			set
			{
				setMaxEms(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxEms18098;
		public virtual void setMaxEms(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxEms", "(I)V", ref global::android.widget.TextView._setMaxEms18098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxWidth
		{
			set
			{
				setMaxWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth18099;
		public virtual void setMaxWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V", ref global::android.widget.TextView._setMaxWidth18099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Ems
		{
			set
			{
				setEms(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEms18100;
		public virtual void setEms(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setEms", "(I)V", ref global::android.widget.TextView._setEms18100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			set
			{
				setWidth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWidth18101;
		public virtual void setWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setWidth", "(I)V", ref global::android.widget.TextView._setWidth18101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineSpacing18102;
		public virtual void setLineSpacing(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V", ref global::android.widget.TextView._setLineSpacing18102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFreezesText18103;
		public virtual void setFreezesText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V", ref global::android.widget.TextView._setFreezesText18103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FreezesText
		{
			get
			{
				return getFreezesText();
			}
			set
			{
				setFreezesText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFreezesText18104;
		public virtual bool getFreezesText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "getFreezesText", "()Z", ref global::android.widget.TextView._getFreezesText18104);
		}
		public new global::android.text.Editable_Factory EditableFactory
		{
			set
			{
				setEditableFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEditableFactory18105;
		public virtual void setEditableFactory(android.text.Editable_Factory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V", ref global::android.widget.TextView._setEditableFactory18105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.Spannable_Factory SpannableFactory
		{
			set
			{
				setSpannableFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSpannableFactory18106;
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V", ref global::android.widget.TextView._setSpannableFactory18106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState18107;
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", ref global::android.widget.TextView._setTextKeepState18107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextKeepState(string arg0, android.widget.TextView.BufferType arg1)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		public new global::java.lang.CharSequence TextKeepState
		{
			set
			{
				setTextKeepState(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState18108;
		public virtual void setTextKeepState(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._setTextKeepState18108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextKeepState(string arg0)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint18109;
		public virtual void setHint(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextView._setHint18109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setHint(string arg0)
		{
			setHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint18110;
		public virtual void setHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setHint", "(I)V", ref global::android.widget.TextView._setHint18110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new string Hint
		{
			get
			{
				return getHint().toString();
			}
			set
			{
				setHint((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHint18111;
		public virtual global::java.lang.CharSequence getHint()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._getHint18111) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setInputType18112;
		public virtual void setInputType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setInputType", "(I)V", ref global::android.widget.TextView._setInputType18112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RawInputType
		{
			set
			{
				setRawInputType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setRawInputType18113;
		public virtual void setRawInputType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setRawInputType", "(I)V", ref global::android.widget.TextView._setRawInputType18113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
			set
			{
				setInputType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType18114;
		public virtual int getInputType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getInputType", "()I", ref global::android.widget.TextView._getInputType18114);
		}
		internal static global::MonoJavaBridge.MethodId _setImeOptions18115;
		public virtual void setImeOptions(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setImeOptions", "(I)V", ref global::android.widget.TextView._setImeOptions18115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ImeOptions
		{
			get
			{
				return getImeOptions();
			}
			set
			{
				setImeOptions(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeOptions18116;
		public virtual int getImeOptions()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getImeOptions", "()I", ref global::android.widget.TextView._getImeOptions18116);
		}
		internal static global::MonoJavaBridge.MethodId _setImeActionLabel18117;
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V", ref global::android.widget.TextView._setImeActionLabel18117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setImeActionLabel(string arg0, int arg1)
		{
			setImeActionLabel((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		public new string ImeActionLabel
		{
			get
			{
				return getImeActionLabel().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionLabel18118;
		public virtual global::java.lang.CharSequence getImeActionLabel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._getImeActionLabel18118) as java.lang.CharSequence;
		}
		public new int ImeActionId
		{
			get
			{
				return getImeActionId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionId18119;
		public virtual int getImeActionId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getImeActionId", "()I", ref global::android.widget.TextView._getImeActionId18119);
		}
		internal static global::MonoJavaBridge.MethodId _setOnEditorActionListener18120;
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V", ref global::android.widget.TextView._setOnEditorActionListener18120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnEditorActionListener(global::android.widget.TextView.OnEditorActionListenerDelegate arg0)
		{
			setOnEditorActionListener((global::android.widget.TextView.OnEditorActionListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onEditorAction18121;
		public virtual void onEditorAction(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onEditorAction", "(I)V", ref global::android.widget.TextView._onEditorAction18121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateImeOptions18122;
		public virtual void setPrivateImeOptions(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V", ref global::android.widget.TextView._setPrivateImeOptions18122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String PrivateImeOptions
		{
			get
			{
				return getPrivateImeOptions();
			}
			set
			{
				setPrivateImeOptions(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateImeOptions18123;
		public virtual global::java.lang.String getPrivateImeOptions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;", ref global::android.widget.TextView._getPrivateImeOptions18123) as java.lang.String;
		}
		public new int InputExtras
		{
			set
			{
				setInputExtras(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInputExtras18124;
		public virtual void setInputExtras(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setInputExtras", "(I)V", ref global::android.widget.TextView._setInputExtras18124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputExtras18125;
		public virtual global::android.os.Bundle getInputExtras(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;", ref global::android.widget.TextView._getInputExtras18125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		public new string Error
		{
			get
			{
				return getError().toString();
			}
			set
			{
				setError((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getError18126;
		public virtual global::java.lang.CharSequence getError()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;", ref global::android.widget.TextView._getError18126) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame18127;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z", ref global::android.widget.TextView._setFrame18127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setFilters18128;
		public virtual void setFilters(android.text.InputFilter[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V", ref global::android.widget.TextView._setFilters18128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.InputFilter[] Filters
		{
			get
			{
				return getFilters();
			}
			set
			{
				setFilters(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilters18129;
		public virtual global::android.text.InputFilter[] getFilters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.text.InputFilter>(this, global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;", ref global::android.widget.TextView._getFilters18129) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _onPreDraw18130;
		public virtual bool onPreDraw()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onPreDraw", "()Z", ref global::android.widget.TextView._onPreDraw18130);
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount18131;
		public virtual int getLineCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLineCount", "()I", ref global::android.widget.TextView._getLineCount18131);
		}
		internal static global::MonoJavaBridge.MethodId _getLineBounds18132;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I", ref global::android.widget.TextView._getLineBounds18132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extractText18133;
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z", ref global::android.widget.TextView._extractText18133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.inputmethod.ExtractedText ExtractedText
		{
			set
			{
				setExtractedText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText18134;
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V", ref global::android.widget.TextView._setExtractedText18134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion18135;
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", ref global::android.widget.TextView._onCommitCompletion18135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit18136;
		public virtual void beginBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "beginBatchEdit", "()V", ref global::android.widget.TextView._beginBatchEdit18136);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit18137;
		public virtual void endBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "endBatchEdit", "()V", ref global::android.widget.TextView._endBatchEdit18137);
		}
		internal static global::MonoJavaBridge.MethodId _onBeginBatchEdit18138;
		public virtual void onBeginBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V", ref global::android.widget.TextView._onBeginBatchEdit18138);
		}
		internal static global::MonoJavaBridge.MethodId _onEndBatchEdit18139;
		public virtual void onEndBatchEdit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V", ref global::android.widget.TextView._onEndBatchEdit18139);
		}
		internal static global::MonoJavaBridge.MethodId _onPrivateIMECommand18140;
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", ref global::android.widget.TextView._onPrivateIMECommand18140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool IncludeFontPadding
		{
			set
			{
				setIncludeFontPadding(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setIncludeFontPadding18141;
		public virtual void setIncludeFontPadding(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V", ref global::android.widget.TextView._setIncludeFontPadding18141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringPointIntoView18142;
		public virtual bool bringPointIntoView(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z", ref global::android.widget.TextView._bringPointIntoView18142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveCursorToVisibleOffset18143;
		public virtual bool moveCursorToVisibleOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z", ref global::android.widget.TextView._moveCursorToVisibleOffset18143);
		}
		public new int SelectionStart
		{
			get
			{
				return getSelectionStart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart18144;
		public virtual int getSelectionStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getSelectionStart", "()I", ref global::android.widget.TextView._getSelectionStart18144);
		}
		public new int SelectionEnd
		{
			get
			{
				return getSelectionEnd();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd18145;
		public virtual int getSelectionEnd()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TextView.staticClass, "getSelectionEnd", "()I", ref global::android.widget.TextView._getSelectionEnd18145);
		}
		internal static global::MonoJavaBridge.MethodId _hasSelection18146;
		public virtual bool hasSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "hasSelection", "()Z", ref global::android.widget.TextView._hasSelection18146);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine18147;
		public virtual void setSingleLine()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSingleLine", "()V", ref global::android.widget.TextView._setSingleLine18147);
		}
		public new bool SingleLine
		{
			set
			{
				setSingleLine(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine18148;
		public virtual void setSingleLine(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V", ref global::android.widget.TextView._setSingleLine18148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEllipsize18149;
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", ref global::android.widget.TextView._setEllipsize18149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MarqueeRepeatLimit
		{
			set
			{
				setMarqueeRepeatLimit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMarqueeRepeatLimit18150;
		public virtual void setMarqueeRepeatLimit(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V", ref global::android.widget.TextView._setMarqueeRepeatLimit18150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.text.TextUtils.TruncateAt Ellipsize
		{
			get
			{
				return getEllipsize();
			}
			set
			{
				setEllipsize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsize18151;
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.text.TextUtils.TruncateAt>(this, global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;", ref global::android.widget.TextView._getEllipsize18151) as android.text.TextUtils.TruncateAt;
		}
		public new bool SelectAllOnFocus
		{
			set
			{
				setSelectAllOnFocus(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelectAllOnFocus18152;
		public virtual void setSelectAllOnFocus(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V", ref global::android.widget.TextView._setSelectAllOnFocus18152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CursorVisible
		{
			set
			{
				setCursorVisible(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCursorVisible18153;
		public virtual void setCursorVisible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V", ref global::android.widget.TextView._setCursorVisible18153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged18154;
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V", ref global::android.widget.TextView._onTextChanged18154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		protected void onTextChanged(string arg0, int arg1, int arg2, int arg3)
		{
			onTextChanged((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged18155;
		protected virtual void onSelectionChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V", ref global::android.widget.TextView._onSelectionChanged18155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTextChangedListener18156;
		public virtual void addTextChangedListener(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V", ref global::android.widget.TextView._addTextChangedListener18156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeTextChangedListener18157;
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V", ref global::android.widget.TextView._removeTextChangedListener18157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearComposingText18158;
		public virtual void clearComposingText()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "clearComposingText", "()V", ref global::android.widget.TextView._clearComposingText18158);
		}
		internal static global::MonoJavaBridge.MethodId _didTouchFocusSelect18159;
		public virtual bool didTouchFocusSelect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z", ref global::android.widget.TextView._didTouchFocusSelect18159);
		}
		public new global::android.widget.Scroller Scroller
		{
			set
			{
				setScroller(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setScroller18160;
		public virtual void setScroller(android.widget.Scroller arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V", ref global::android.widget.TextView._setScroller18160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextColor18161;
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._getTextColor18161.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._getTextColor18161 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I");
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColor18161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget18162;
		public virtual bool isInputMethodTarget()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z", ref global::android.widget.TextView._isInputMethodTarget18162);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem18163;
		public virtual bool onTextContextMenuItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z", ref global::android.widget.TextView._onTextContextMenuItem18163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextView18164;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._TextView18164.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._TextView18164 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView18165;
		public TextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._TextView18165.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._TextView18165 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView18166;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextView._TextView18166.native == global::System.IntPtr.Zero)
				global::android.widget.TextView._TextView18166 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView18166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
