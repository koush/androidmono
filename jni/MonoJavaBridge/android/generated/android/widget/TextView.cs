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
			internal static global::MonoJavaBridge.MethodId _values12665;
			public static global::android.widget.TextView.BufferType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.TextView.BufferType>(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._values12665)) as android.widget.TextView.BufferType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf12666;
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._valueOf12666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TextView.BufferType;
			}
			internal static global::MonoJavaBridge.FieldId _EDITABLE12667;
			public static global::android.widget.TextView.BufferType EDITABLE
			{
				get
				{
					return default(global::android.widget.TextView.BufferType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NORMAL12668;
			public static global::android.widget.TextView.BufferType NORMAL
			{
				get
				{
					return default(global::android.widget.TextView.BufferType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPANNABLE12669;
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
				global::android.widget.TextView.BufferType._values12665 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;");
				global::android.widget.TextView.BufferType._valueOf12666 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;");
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
			internal static global::MonoJavaBridge.MethodId _onEditorAction12670;
			 bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_._onEditorAction12670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.OnEditorActionListener_.staticClass, global::android.widget.TextView.OnEditorActionListener_._onEditorAction12670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TextView.OnEditorActionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView$OnEditorActionListener"));
				global::android.widget.TextView.OnEditorActionListener_._onEditorAction12670 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.OnEditorActionListener_.staticClass, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z");
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
			internal static global::MonoJavaBridge.MethodId _toString12671;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState._toString12671)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._toString12671)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel12672;
			public override void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState._writeToParcel12672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._writeToParcel12672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR12673;
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
				global::android.widget.TextView.SavedState._toString12671 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;");
				global::android.widget.TextView.SavedState._writeToParcel12672 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _append12674;
		public virtual void append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append12674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append12674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void append(string arg0)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append12675;
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._append12675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._append12675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void append(string arg0, int arg1, int arg2)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _length12676;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._length12676);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._length12676);
		}
		internal static global::MonoJavaBridge.MethodId _debug12677;
		public virtual void debug(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._debug12677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._debug12677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setError12678;
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError12678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError12678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setError(string arg0, android.graphics.drawable.Drawable arg1)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setError12679;
		public virtual void setError(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setError12679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError12679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setError(string arg0)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText12680;
		public virtual void setText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setText12681;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText12682;
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setText12683;
		public virtual void setText(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setText12684;
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setText12684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText12684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getText12685;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getText12685)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getText12685)) as java.lang.CharSequence;
		}
		public new global::android.text.Layout Layout
		{
			get
			{
				return getLayout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayout12686;
		public virtual global::android.text.Layout getLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLayout12686)) as android.text.Layout;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLayout12686)) as android.text.Layout;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState12687;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onRestoreInstanceState12687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onRestoreInstanceState12687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState12688;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onSaveInstanceState12688)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSaveInstanceState12688)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown12689;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyDown12689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyDown12689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp12690;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyUp12690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyUp12690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple12691;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyMultiple12691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyMultiple12691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12692;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTouchEvent12692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTouchEvent12692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent12693;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTrackballEvent12693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTrackballEvent12693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged12694;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onWindowFocusChanged12694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onWindowFocusChanged12694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow12695;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onAttachedToWindow12695);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onAttachedToWindow12695);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow12696;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDetachedFromWindow12696);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDetachedFromWindow12696);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent12697;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._dispatchPopulateAccessibilityEvent12697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._dispatchPopulateAccessibilityEvent12697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu12698;
		protected override void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCreateContextMenu12698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateContextMenu12698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity12699;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setGravity12699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setGravity12699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick12700;
		public override bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._performLongClick12700);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._performLongClick12700);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged12701;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFocusChanged12701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFocusChanged12701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onStartTemporaryDetach12702;
		public override void onStartTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onStartTemporaryDetach12702);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onStartTemporaryDetach12702);
		}
		internal static global::MonoJavaBridge.MethodId _onFinishTemporaryDetach12703;
		public override void onFinishTemporaryDetach() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onFinishTemporaryDetach12703);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFinishTemporaryDetach12703);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyShortcut12704;
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onKeyShortcut12704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyShortcut12704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCheckIsTextEditor12705;
		public override bool onCheckIsTextEditor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onCheckIsTextEditor12705);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCheckIsTextEditor12705);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection12706;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._onCreateInputConnection12706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateInputConnection12706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _cancelLongPress12707;
		public override void cancelLongPress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._cancelLongPress12707);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._cancelLongPress12707);
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedRect12708;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._getFocusedRect12708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFocusedRect12708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll12709;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._computeScroll12709);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeScroll12709);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftFadingEdgeStrength12710;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getLeftFadingEdgeStrength12710);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftFadingEdgeStrength12710);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightFadingEdgeStrength12711;
		protected override float getRightFadingEdgeStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getRightFadingEdgeStrength12711);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightFadingEdgeStrength12711);
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange12712;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeHorizontalScrollRange12712);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeHorizontalScrollRange12712);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange12713;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollRange12713);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollRange12713);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent12714;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._computeVerticalScrollExtent12714);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollExtent12714);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw12715;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onDraw12715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDraw12715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPaddingOffsetRequired12716;
		protected override bool isPaddingOffsetRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isPaddingOffsetRequired12716);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isPaddingOffsetRequired12716);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLeftPaddingOffset12717;
		protected override int getLeftPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLeftPaddingOffset12717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftPaddingOffset12717);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRightPaddingOffset12718;
		protected override int getRightPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getRightPaddingOffset12718);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightPaddingOffset12718);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPaddingOffset12719;
		protected override int getTopPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTopPaddingOffset12719);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTopPaddingOffset12719);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPaddingOffset12720;
		protected override int getBottomPaddingOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBottomPaddingOffset12720);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBottomPaddingOffset12720);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable12721;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._invalidateDrawable12721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._invalidateDrawable12721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable12722;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._verifyDrawable12722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._verifyDrawable12722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged12723;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._drawableStateChanged12723);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._drawableStateChanged12723);
		}
		internal static global::MonoJavaBridge.MethodId _setPadding12724;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPadding12724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPadding12724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setSelected12725;
		public override void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelected12725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelected12725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12726;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getBaseline12726);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBaseline12726);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12727;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onMeasure12727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onMeasure12727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface12728;
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface12728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface12728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTypeface12729;
		public virtual void setTypeface(android.graphics.Typeface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTypeface12729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface12729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new bool DefaultEditable
		{
			get
			{
				return getDefaultEditable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEditable12730;
		protected virtual bool getDefaultEditable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getDefaultEditable12730);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultEditable12730);
		}
		protected new global::android.text.method.MovementMethod DefaultMovementMethod
		{
			get
			{
				return getDefaultMovementMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMovementMethod12731;
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getDefaultMovementMethod12731)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultMovementMethod12731)) as android.text.method.MovementMethod;
		}
		public new global::android.text.Editable EditableText
		{
			get
			{
				return getEditableText();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEditableText12732;
		public virtual global::android.text.Editable getEditableText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEditableText12732)) as android.text.Editable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Editable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEditableText12732)) as android.text.Editable;
		}
		public new int LineHeight
		{
			get
			{
				return getLineHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineHeight12733;
		public virtual int getLineHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineHeight12733);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineHeight12733);
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
		internal static global::MonoJavaBridge.MethodId _getKeyListener12734;
		public virtual global::android.text.method.KeyListener getKeyListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getKeyListener12734)) as android.text.method.KeyListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.KeyListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getKeyListener12734)) as android.text.method.KeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _setKeyListener12735;
		public virtual void setKeyListener(android.text.method.KeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setKeyListener12735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setKeyListener12735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMovementMethod12736;
		public virtual global::android.text.method.MovementMethod getMovementMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getMovementMethod12736)) as android.text.method.MovementMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.MovementMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getMovementMethod12736)) as android.text.method.MovementMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setMovementMethod12737;
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMovementMethod12737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMovementMethod12737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTransformationMethod12738;
		public virtual global::android.text.method.TransformationMethod getTransformationMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTransformationMethod12738)) as android.text.method.TransformationMethod;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.method.TransformationMethod>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTransformationMethod12738)) as android.text.method.TransformationMethod;
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationMethod12739;
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTransformationMethod12739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTransformationMethod12739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CompoundPaddingTop
		{
			get
			{
				return getCompoundPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingTop12740;
		public virtual int getCompoundPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingTop12740);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingTop12740);
		}
		public new int CompoundPaddingBottom
		{
			get
			{
				return getCompoundPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingBottom12741;
		public virtual int getCompoundPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingBottom12741);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingBottom12741);
		}
		public new int CompoundPaddingLeft
		{
			get
			{
				return getCompoundPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingLeft12742;
		public virtual int getCompoundPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingLeft12742);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingLeft12742);
		}
		public new int CompoundPaddingRight
		{
			get
			{
				return getCompoundPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundPaddingRight12743;
		public virtual int getCompoundPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundPaddingRight12743);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingRight12743);
		}
		public new int ExtendedPaddingTop
		{
			get
			{
				return getExtendedPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingTop12744;
		public virtual int getExtendedPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingTop12744);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingTop12744);
		}
		public new int ExtendedPaddingBottom
		{
			get
			{
				return getExtendedPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtendedPaddingBottom12745;
		public virtual int getExtendedPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getExtendedPaddingBottom12745);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingBottom12745);
		}
		public new int TotalPaddingLeft
		{
			get
			{
				return getTotalPaddingLeft();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingLeft12746;
		public virtual int getTotalPaddingLeft() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingLeft12746);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingLeft12746);
		}
		public new int TotalPaddingRight
		{
			get
			{
				return getTotalPaddingRight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingRight12747;
		public virtual int getTotalPaddingRight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingRight12747);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingRight12747);
		}
		public new int TotalPaddingTop
		{
			get
			{
				return getTotalPaddingTop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingTop12748;
		public virtual int getTotalPaddingTop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingTop12748);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingTop12748);
		}
		public new int TotalPaddingBottom
		{
			get
			{
				return getTotalPaddingBottom();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTotalPaddingBottom12749;
		public virtual int getTotalPaddingBottom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getTotalPaddingBottom12749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingBottom12749);
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawables12750;
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawables12750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawables12750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds12751;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablesWithIntrinsicBounds12752;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.drawable.Drawable[] CompoundDrawables
		{
			get
			{
				return getCompoundDrawables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawables12753;
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawables12753)) as android.graphics.drawable.Drawable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawables12753)) as android.graphics.drawable.Drawable[];
		}
		internal static global::MonoJavaBridge.MethodId _setCompoundDrawablePadding12754;
		public virtual void setCompoundDrawablePadding(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCompoundDrawablePadding12754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablePadding12754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCompoundDrawablePadding12755;
		public virtual int getCompoundDrawablePadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCompoundDrawablePadding12755);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawablePadding12755);
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
		internal static global::MonoJavaBridge.MethodId _getAutoLinkMask12756;
		public virtual int getAutoLinkMask() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getAutoLinkMask12756);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getAutoLinkMask12756);
		}
		internal static global::MonoJavaBridge.MethodId _setTextAppearance12757;
		public virtual void setTextAppearance(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextAppearance12757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextAppearance12757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getTextSize12758;
		public virtual float getTextSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextSize12758);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextSize12758);
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize12759;
		public virtual void setTextSize(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize12759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize12759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTextSize12760;
		public virtual void setTextSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextSize12760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize12760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTextScaleX12761;
		public virtual float getTextScaleX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.TextView._getTextScaleX12761);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextScaleX12761);
		}
		internal static global::MonoJavaBridge.MethodId _setTextScaleX12762;
		public virtual void setTextScaleX(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextScaleX12762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextScaleX12762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTypeface12763;
		public virtual global::android.graphics.Typeface getTypeface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTypeface12763)) as android.graphics.Typeface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTypeface12763)) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor12764;
		public virtual void setTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor12764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor12764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextColor12765;
		public virtual void setTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextColor12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList TextColors
		{
			get
			{
				return getTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors12766;
		public virtual global::android.content.res.ColorStateList getTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getTextColors12766)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors12766)) as android.content.res.ColorStateList;
		}
		internal static global::MonoJavaBridge.MethodId _getTextColors12767;
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.ColorStateList;
		}
		public new int CurrentTextColor
		{
			get
			{
				return getCurrentTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTextColor12768;
		public virtual int getCurrentTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentTextColor12768);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentTextColor12768);
		}
		internal static global::MonoJavaBridge.MethodId _setHighlightColor12769;
		public virtual void setHighlightColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHighlightColor12769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHighlightColor12769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShadowLayer12770;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setShadowLayer12770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setShadowLayer12770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.text.TextPaint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint12771;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPaint12771)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaint12771)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _setAutoLinkMask12772;
		public virtual void setAutoLinkMask(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setAutoLinkMask12772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setAutoLinkMask12772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinksClickable12773;
		public virtual void setLinksClickable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinksClickable12773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinksClickable12773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLinksClickable12774;
		public virtual bool getLinksClickable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getLinksClickable12774);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinksClickable12774);
		}
		public new global::android.text.style.URLSpan[] Urls
		{
			get
			{
				return getUrls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrls12775;
		public virtual global::android.text.style.URLSpan[] getUrls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getUrls12775)) as android.text.style.URLSpan[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.style.URLSpan>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getUrls12775)) as android.text.style.URLSpan[];
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor12776;
		public virtual void setHintTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor12776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor12776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHintTextColor12777;
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHintTextColor12777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor12777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList HintTextColors
		{
			get
			{
				return getHintTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHintTextColors12778;
		public virtual global::android.content.res.ColorStateList getHintTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHintTextColors12778)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHintTextColors12778)) as android.content.res.ColorStateList;
		}
		public new int CurrentHintTextColor
		{
			get
			{
				return getCurrentHintTextColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentHintTextColor12779;
		public virtual int getCurrentHintTextColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getCurrentHintTextColor12779);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentHintTextColor12779);
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor12780;
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor12780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor12780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLinkTextColor12781;
		public virtual void setLinkTextColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLinkTextColor12781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor12781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.ColorStateList LinkTextColors
		{
			get
			{
				return getLinkTextColors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLinkTextColors12782;
		public virtual global::android.content.res.ColorStateList getLinkTextColors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getLinkTextColors12782)) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinkTextColors12782)) as android.content.res.ColorStateList;
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
		internal static global::MonoJavaBridge.MethodId _getGravity12783;
		public virtual int getGravity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getGravity12783);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getGravity12783);
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
		internal static global::MonoJavaBridge.MethodId _getPaintFlags12784;
		public virtual int getPaintFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getPaintFlags12784);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaintFlags12784);
		}
		internal static global::MonoJavaBridge.MethodId _setPaintFlags12785;
		public virtual void setPaintFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPaintFlags12785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPaintFlags12785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontallyScrolling12786;
		public virtual void setHorizontallyScrolling(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHorizontallyScrolling12786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHorizontallyScrolling12786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinLines12787;
		public virtual void setMinLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinLines12787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinLines12787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinHeight12788;
		public virtual void setMinHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinHeight12788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinHeight12788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxLines12789;
		public virtual void setMaxLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxLines12789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxLines12789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight12790;
		public virtual void setMaxHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxHeight12790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxHeight12790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLines12791;
		public virtual void setLines(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLines12791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLines12791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeight12792;
		public virtual void setHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHeight12792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHeight12792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinEms12793;
		public virtual void setMinEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinEms12793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinEms12793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinWidth12794;
		public virtual void setMinWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMinWidth12794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinWidth12794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxEms12795;
		public virtual void setMaxEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxEms12795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxEms12795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth12796;
		public virtual void setMaxWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMaxWidth12796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxWidth12796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEms12797;
		public virtual void setEms(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEms12797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEms12797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWidth12798;
		public virtual void setWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setWidth12798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setWidth12798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLineSpacing12799;
		public virtual void setLineSpacing(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setLineSpacing12799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLineSpacing12799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFreezesText12800;
		public virtual void setFreezesText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFreezesText12800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFreezesText12800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFreezesText12801;
		public virtual bool getFreezesText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._getFreezesText12801);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFreezesText12801);
		}
		internal static global::MonoJavaBridge.MethodId _setEditableFactory12802;
		public virtual void setEditableFactory(android.text.Editable_Factory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEditableFactory12802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEditableFactory12802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSpannableFactory12803;
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSpannableFactory12803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSpannableFactory12803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState12804;
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState12804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState12804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setTextKeepState(string arg0, android.widget.TextView.BufferType arg1)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setTextKeepState12805;
		public virtual void setTextKeepState(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setTextKeepState12805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState12805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextKeepState(string arg0)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint12806;
		public virtual void setHint(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint12806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint12806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setHint(string arg0)
		{
			setHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setHint12807;
		public virtual void setHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setHint12807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint12807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getHint12808;
		public virtual global::java.lang.CharSequence getHint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getHint12808)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHint12808)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setInputType12809;
		public virtual void setInputType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputType12809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputType12809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawInputType12810;
		public virtual void setRawInputType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setRawInputType12810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setRawInputType12810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getInputType12811;
		public virtual int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getInputType12811);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputType12811);
		}
		internal static global::MonoJavaBridge.MethodId _setImeOptions12812;
		public virtual void setImeOptions(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeOptions12812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeOptions12812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getImeOptions12813;
		public virtual int getImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeOptions12813);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeOptions12813);
		}
		internal static global::MonoJavaBridge.MethodId _setImeActionLabel12814;
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setImeActionLabel12814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeActionLabel12814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getImeActionLabel12815;
		public virtual global::java.lang.CharSequence getImeActionLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getImeActionLabel12815)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionLabel12815)) as java.lang.CharSequence;
		}
		public new int ImeActionId
		{
			get
			{
				return getImeActionId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImeActionId12816;
		public virtual int getImeActionId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getImeActionId12816);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionId12816);
		}
		internal static global::MonoJavaBridge.MethodId _setOnEditorActionListener12817;
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setOnEditorActionListener12817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setOnEditorActionListener12817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEditorAction12818;
		public virtual void onEditorAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEditorAction12818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEditorAction12818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrivateImeOptions12819;
		public virtual void setPrivateImeOptions(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setPrivateImeOptions12819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPrivateImeOptions12819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPrivateImeOptions12820;
		public virtual global::java.lang.String getPrivateImeOptions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getPrivateImeOptions12820)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPrivateImeOptions12820)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setInputExtras12821;
		public virtual void setInputExtras(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setInputExtras12821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputExtras12821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInputExtras12822;
		public virtual global::android.os.Bundle getInputExtras(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getInputExtras12822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputExtras12822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
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
		internal static global::MonoJavaBridge.MethodId _getError12823;
		public virtual global::java.lang.CharSequence getError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getError12823)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getError12823)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setFrame12824;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._setFrame12824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFrame12824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setFilters12825;
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setFilters12825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFilters12825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFilters12826;
		public virtual global::android.text.InputFilter[] getFilters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getFilters12826)) as android.text.InputFilter[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.InputFilter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFilters12826)) as android.text.InputFilter[];
		}
		internal static global::MonoJavaBridge.MethodId _onPreDraw12827;
		public virtual bool onPreDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPreDraw12827);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPreDraw12827);
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount12828;
		public virtual int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineCount12828);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineCount12828);
		}
		internal static global::MonoJavaBridge.MethodId _getLineBounds12829;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getLineBounds12829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineBounds12829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _extractText12830;
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._extractText12830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._extractText12830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setExtractedText12831;
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setExtractedText12831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setExtractedText12831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCommitCompletion12832;
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onCommitCompletion12832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCommitCompletion12832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _beginBatchEdit12833;
		public virtual void beginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._beginBatchEdit12833);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._beginBatchEdit12833);
		}
		internal static global::MonoJavaBridge.MethodId _endBatchEdit12834;
		public virtual void endBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._endBatchEdit12834);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._endBatchEdit12834);
		}
		internal static global::MonoJavaBridge.MethodId _onBeginBatchEdit12835;
		public virtual void onBeginBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onBeginBatchEdit12835);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onBeginBatchEdit12835);
		}
		internal static global::MonoJavaBridge.MethodId _onEndBatchEdit12836;
		public virtual void onEndBatchEdit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onEndBatchEdit12836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEndBatchEdit12836);
		}
		internal static global::MonoJavaBridge.MethodId _onPrivateIMECommand12837;
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onPrivateIMECommand12837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPrivateIMECommand12837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIncludeFontPadding12838;
		public virtual void setIncludeFontPadding(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setIncludeFontPadding12838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setIncludeFontPadding12838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringPointIntoView12839;
		public virtual bool bringPointIntoView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._bringPointIntoView12839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._bringPointIntoView12839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveCursorToVisibleOffset12840;
		public virtual bool moveCursorToVisibleOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._moveCursorToVisibleOffset12840);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._moveCursorToVisibleOffset12840);
		}
		public new int SelectionStart
		{
			get
			{
				return getSelectionStart();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionStart12841;
		public virtual int getSelectionStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionStart12841);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionStart12841);
		}
		public new int SelectionEnd
		{
			get
			{
				return getSelectionEnd();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionEnd12842;
		public virtual int getSelectionEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TextView._getSelectionEnd12842);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionEnd12842);
		}
		internal static global::MonoJavaBridge.MethodId _hasSelection12843;
		public virtual bool hasSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._hasSelection12843);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._hasSelection12843);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine12844;
		public virtual void setSingleLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine12844);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine12844);
		}
		internal static global::MonoJavaBridge.MethodId _setSingleLine12845;
		public virtual void setSingleLine(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSingleLine12845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine12845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEllipsize12846;
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setEllipsize12846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEllipsize12846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMarqueeRepeatLimit12847;
		public virtual void setMarqueeRepeatLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setMarqueeRepeatLimit12847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMarqueeRepeatLimit12847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEllipsize12848;
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TextView._getEllipsize12848)) as android.text.TextUtils.TruncateAt;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEllipsize12848)) as android.text.TextUtils.TruncateAt;
		}
		internal static global::MonoJavaBridge.MethodId _setSelectAllOnFocus12849;
		public virtual void setSelectAllOnFocus(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setSelectAllOnFocus12849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelectAllOnFocus12849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorVisible12850;
		public virtual void setCursorVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setCursorVisible12850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCursorVisible12850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTextChanged12851;
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onTextChanged12851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextChanged12851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSelectionChanged12852;
		protected virtual void onSelectionChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._onSelectionChanged12852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSelectionChanged12852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addTextChangedListener12853;
		public virtual void addTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._addTextChangedListener12853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._addTextChangedListener12853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeTextChangedListener12854;
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._removeTextChangedListener12854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._removeTextChangedListener12854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearComposingText12855;
		public virtual void clearComposingText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._clearComposingText12855);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._clearComposingText12855);
		}
		internal static global::MonoJavaBridge.MethodId _didTouchFocusSelect12856;
		public virtual bool didTouchFocusSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._didTouchFocusSelect12856);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._didTouchFocusSelect12856);
		}
		internal static global::MonoJavaBridge.MethodId _setScroller12857;
		public virtual void setScroller(android.widget.Scroller arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextView._setScroller12857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._setScroller12857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTextColor12858;
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColor12858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isInputMethodTarget12859;
		public virtual bool isInputMethodTarget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._isInputMethodTarget12859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._isInputMethodTarget12859);
		}
		internal static global::MonoJavaBridge.MethodId _onTextContextMenuItem12860;
		public virtual bool onTextContextMenuItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TextView._onTextContextMenuItem12860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextContextMenuItem12860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TextView12861;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView12861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView12862;
		public TextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView12862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextView12863;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView12863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextView"));
			global::android.widget.TextView._append12674 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._append12675 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V");
			global::android.widget.TextView._length12676 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "length", "()I");
			global::android.widget.TextView._debug12677 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "debug", "(I)V");
			global::android.widget.TextView._setError12678 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setError12679 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText12680 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(I)V");
			global::android.widget.TextView._setText12681 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText12682 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setText12683 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "([CII)V");
			global::android.widget.TextView._setText12684 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._getText12685 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getLayout12686 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;");
			global::android.widget.TextView._onRestoreInstanceState12687 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TextView._onSaveInstanceState12688 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TextView._onKeyDown12689 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyUp12690 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyMultiple12691 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onTouchEvent12692 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onTrackballEvent12693 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onWindowFocusChanged12694 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.TextView._onAttachedToWindow12695 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TextView._onDetachedFromWindow12696 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TextView._dispatchPopulateAccessibilityEvent12697 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.TextView._onCreateContextMenu12698 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.widget.TextView._setGravity12699 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setGravity", "(I)V");
			global::android.widget.TextView._performLongClick12700 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "performLongClick", "()Z");
			global::android.widget.TextView._onFocusChanged12701 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.TextView._onStartTemporaryDetach12702 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V");
			global::android.widget.TextView._onFinishTemporaryDetach12703 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.widget.TextView._onKeyShortcut12704 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onCheckIsTextEditor12705 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.widget.TextView._onCreateInputConnection12706 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.TextView._cancelLongPress12707 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "cancelLongPress", "()V");
			global::android.widget.TextView._getFocusedRect12708 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.TextView._computeScroll12709 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeScroll", "()V");
			global::android.widget.TextView._getLeftFadingEdgeStrength12710 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.TextView._getRightFadingEdgeStrength12711 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.TextView._computeHorizontalScrollRange12712 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollRange12713 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollExtent12714 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.TextView._onDraw12715 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TextView._isPaddingOffsetRequired12716 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.widget.TextView._getLeftPaddingOffset12717 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I");
			global::android.widget.TextView._getRightPaddingOffset12718 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I");
			global::android.widget.TextView._getTopPaddingOffset12719 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I");
			global::android.widget.TextView._getBottomPaddingOffset12720 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I");
			global::android.widget.TextView._invalidateDrawable12721 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._verifyDrawable12722 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.TextView._drawableStateChanged12723 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.TextView._setPadding12724 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.TextView._setSelected12725 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelected", "(Z)V");
			global::android.widget.TextView._getBaseline12726 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getBaseline", "()I");
			global::android.widget.TextView._onMeasure12727 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onMeasure", "(II)V");
			global::android.widget.TextView._setTypeface12728 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V");
			global::android.widget.TextView._setTypeface12729 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V");
			global::android.widget.TextView._getDefaultEditable12730 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z");
			global::android.widget.TextView._getDefaultMovementMethod12731 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._getEditableText12732 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;");
			global::android.widget.TextView._getLineHeight12733 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineHeight", "()I");
			global::android.widget.TextView._getKeyListener12734 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;");
			global::android.widget.TextView._setKeyListener12735 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V");
			global::android.widget.TextView._getMovementMethod12736 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._setMovementMethod12737 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V");
			global::android.widget.TextView._getTransformationMethod12738 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;");
			global::android.widget.TextView._setTransformationMethod12739 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V");
			global::android.widget.TextView._getCompoundPaddingTop12740 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I");
			global::android.widget.TextView._getCompoundPaddingBottom12741 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I");
			global::android.widget.TextView._getCompoundPaddingLeft12742 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I");
			global::android.widget.TextView._getCompoundPaddingRight12743 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I");
			global::android.widget.TextView._getExtendedPaddingTop12744 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I");
			global::android.widget.TextView._getExtendedPaddingBottom12745 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I");
			global::android.widget.TextView._getTotalPaddingLeft12746 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I");
			global::android.widget.TextView._getTotalPaddingRight12747 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I");
			global::android.widget.TextView._getTotalPaddingTop12748 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I");
			global::android.widget.TextView._getTotalPaddingBottom12749 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I");
			global::android.widget.TextView._setCompoundDrawables12750 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12751 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds12752 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V");
			global::android.widget.TextView._getCompoundDrawables12753 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;");
			global::android.widget.TextView._setCompoundDrawablePadding12754 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V");
			global::android.widget.TextView._getCompoundDrawablePadding12755 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I");
			global::android.widget.TextView._getAutoLinkMask12756 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I");
			global::android.widget.TextView._setTextAppearance12757 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V");
			global::android.widget.TextView._getTextSize12758 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextSize", "()F");
			global::android.widget.TextView._setTextSize12759 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(IF)V");
			global::android.widget.TextView._setTextSize12760 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextSize", "(F)V");
			global::android.widget.TextView._getTextScaleX12761 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextScaleX", "()F");
			global::android.widget.TextView._setTextScaleX12762 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V");
			global::android.widget.TextView._getTypeface12763 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.widget.TextView._setTextColor12764 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(I)V");
			global::android.widget.TextView._setTextColor12765 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getTextColors12766 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getTextColors12767 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentTextColor12768 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I");
			global::android.widget.TextView._setHighlightColor12769 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V");
			global::android.widget.TextView._setShadowLayer12770 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.widget.TextView._getPaint12771 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.widget.TextView._setAutoLinkMask12772 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V");
			global::android.widget.TextView._setLinksClickable12773 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V");
			global::android.widget.TextView._getLinksClickable12774 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinksClickable", "()Z");
			global::android.widget.TextView._getUrls12775 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;");
			global::android.widget.TextView._setHintTextColor12776 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V");
			global::android.widget.TextView._setHintTextColor12777 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getHintTextColors12778 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentHintTextColor12779 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I");
			global::android.widget.TextView._setLinkTextColor12780 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._setLinkTextColor12781 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V");
			global::android.widget.TextView._getLinkTextColors12782 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getGravity12783 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getGravity", "()I");
			global::android.widget.TextView._getPaintFlags12784 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPaintFlags", "()I");
			global::android.widget.TextView._setPaintFlags12785 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V");
			global::android.widget.TextView._setHorizontallyScrolling12786 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V");
			global::android.widget.TextView._setMinLines12787 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinLines", "(I)V");
			global::android.widget.TextView._setMinHeight12788 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinHeight", "(I)V");
			global::android.widget.TextView._setMaxLines12789 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxLines", "(I)V");
			global::android.widget.TextView._setMaxHeight12790 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.TextView._setLines12791 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLines", "(I)V");
			global::android.widget.TextView._setHeight12792 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHeight", "(I)V");
			global::android.widget.TextView._setMinEms12793 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinEms", "(I)V");
			global::android.widget.TextView._setMinWidth12794 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMinWidth", "(I)V");
			global::android.widget.TextView._setMaxEms12795 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxEms", "(I)V");
			global::android.widget.TextView._setMaxWidth12796 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.TextView._setEms12797 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEms", "(I)V");
			global::android.widget.TextView._setWidth12798 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setWidth", "(I)V");
			global::android.widget.TextView._setLineSpacing12799 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V");
			global::android.widget.TextView._setFreezesText12800 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V");
			global::android.widget.TextView._getFreezesText12801 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFreezesText", "()Z");
			global::android.widget.TextView._setEditableFactory12802 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V");
			global::android.widget.TextView._setSpannableFactory12803 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V");
			global::android.widget.TextView._setTextKeepState12804 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setTextKeepState12805 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint12806 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint12807 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setHint", "(I)V");
			global::android.widget.TextView._getHint12808 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setInputType12809 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputType", "(I)V");
			global::android.widget.TextView._setRawInputType12810 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setRawInputType", "(I)V");
			global::android.widget.TextView._getInputType12811 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputType", "()I");
			global::android.widget.TextView._setImeOptions12812 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeOptions", "(I)V");
			global::android.widget.TextView._getImeOptions12813 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeOptions", "()I");
			global::android.widget.TextView._setImeActionLabel12814 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.TextView._getImeActionLabel12815 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getImeActionId12816 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getImeActionId", "()I");
			global::android.widget.TextView._setOnEditorActionListener12817 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V");
			global::android.widget.TextView._onEditorAction12818 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEditorAction", "(I)V");
			global::android.widget.TextView._setPrivateImeOptions12819 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V");
			global::android.widget.TextView._getPrivateImeOptions12820 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;");
			global::android.widget.TextView._setInputExtras12821 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setInputExtras", "(I)V");
			global::android.widget.TextView._getInputExtras12822 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;");
			global::android.widget.TextView._getError12823 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setFrame12824 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.TextView._setFilters12825 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.widget.TextView._getFilters12826 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.widget.TextView._onPreDraw12827 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPreDraw", "()Z");
			global::android.widget.TextView._getLineCount12828 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineCount", "()I");
			global::android.widget.TextView._getLineBounds12829 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.widget.TextView._extractText12830 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z");
			global::android.widget.TextView._setExtractedText12831 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.widget.TextView._onCommitCompletion12832 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.TextView._beginBatchEdit12833 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "beginBatchEdit", "()V");
			global::android.widget.TextView._endBatchEdit12834 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "endBatchEdit", "()V");
			global::android.widget.TextView._onBeginBatchEdit12835 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V");
			global::android.widget.TextView._onEndBatchEdit12836 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V");
			global::android.widget.TextView._onPrivateIMECommand12837 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.widget.TextView._setIncludeFontPadding12838 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V");
			global::android.widget.TextView._bringPointIntoView12839 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z");
			global::android.widget.TextView._moveCursorToVisibleOffset12840 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z");
			global::android.widget.TextView._getSelectionStart12841 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionStart", "()I");
			global::android.widget.TextView._getSelectionEnd12842 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getSelectionEnd", "()I");
			global::android.widget.TextView._hasSelection12843 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "hasSelection", "()Z");
			global::android.widget.TextView._setSingleLine12844 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "()V");
			global::android.widget.TextView._setSingleLine12845 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V");
			global::android.widget.TextView._setEllipsize12846 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V");
			global::android.widget.TextView._setMarqueeRepeatLimit12847 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V");
			global::android.widget.TextView._getEllipsize12848 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;");
			global::android.widget.TextView._setSelectAllOnFocus12849 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V");
			global::android.widget.TextView._setCursorVisible12850 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V");
			global::android.widget.TextView._onTextChanged12851 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.TextView._onSelectionChanged12852 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V");
			global::android.widget.TextView._addTextChangedListener12853 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._removeTextChangedListener12854 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._clearComposingText12855 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "clearComposingText", "()V");
			global::android.widget.TextView._didTouchFocusSelect12856 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z");
			global::android.widget.TextView._setScroller12857 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V");
			global::android.widget.TextView._getTextColor12858 = @__env.GetStaticMethodIDNoThrow(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I");
			global::android.widget.TextView._isInputMethodTarget12859 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z");
			global::android.widget.TextView._onTextContextMenuItem12860 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.widget.TextView._TextView12861 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TextView._TextView12862 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TextView._TextView12863 = @__env.GetMethodIDNoThrow(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
