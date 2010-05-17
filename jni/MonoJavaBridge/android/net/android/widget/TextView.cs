namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TextView : android.view.View, android.view.ViewTreeObserver.OnPreDrawListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TextView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.TextView(@__env); 
			} 
		} 
		protected TextView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class BufferType : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static BufferType() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TextView.BufferType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TextView.BufferType(@__env); 
				} 
			} 
			internal BufferType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10212; 
			public static android.widget.TextView.BufferType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView.BufferType>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.BufferType.staticClass, _valueOf10212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values10213; 
			public static android.widget.TextView.BufferType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.BufferType.staticClass, _values10213)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _EDITABLE10214; 
			public static android.widget.TextView.BufferType EDITABLE
			{ 
				get 
				{ 
					return default(android.widget.TextView.BufferType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL10215; 
			public static android.widget.TextView.BufferType NORMAL
			{ 
				get 
				{ 
					return default(android.widget.TextView.BufferType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SPANNABLE10216; 
			public static android.widget.TextView.BufferType SPANNABLE
			{ 
				get 
				{ 
					return default(android.widget.TextView.BufferType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TextView.BufferType.staticClass = @__class; 
				global::android.widget.TextView.BufferType._valueOf10212 = @__env.GetStaticMethodID(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;"); 
				global::android.widget.TextView.BufferType._values10213 = @__env.GetStaticMethodID(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnEditorActionListener 
		{ 
			bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SavedState : android.view.View.BaseSavedState
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SavedState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TextView.SavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TextView.SavedState(@__env); 
				} 
			} 
			protected SavedState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString10217; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TextView.SavedState)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10217)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.SavedState.staticClass, _toString10217)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel10218; 
			public override void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TextView.SavedState)) 
					@__env.CallVoidMethod(this, _writeToParcel10218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.SavedState.staticClass, _writeToParcel10218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR10219; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TextView.SavedState.staticClass = @__class; 
				global::android.widget.TextView.SavedState._toString10217 = @__env.GetMethodID(global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.widget.TextView.SavedState._writeToParcel10218 = @__env.GetMethodID(global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10220; 
		public virtual void append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _append10220, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _append10220, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append10221; 
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _append10221, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _append10221, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length10222; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _length10222); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _length10222); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _debug10223; 
		public virtual void debug(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _debug10223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _debug10223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setError10224; 
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setError10224, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setError10224, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setError10225; 
		public virtual void setError(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setError10225, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setError10225, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText10226; 
		public virtual void setText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setText10226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setText10226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText10227; 
		public virtual void setText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setText10227, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setText10227, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText10228; 
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setText10228, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setText10228, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText10229; 
		public virtual void setText(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setText10229, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setText10229, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText10230; 
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setText10230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setText10230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText10231; 
		public virtual java.lang.CharSequence getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getText10231)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getText10231)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayout10232; 
		public virtual android.text.Layout getLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout>(@__env, @__env.CallObjectMethodPtr(this, _getLayout10232)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getLayout10232)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10233; 
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState10233, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onRestoreInstanceState10233, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10234; 
		public virtual new android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState10234)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _onSaveInstanceState10234)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10235; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onKeyDown10235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onKeyDown10235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10236; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onKeyUp10236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onKeyUp10236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple10237; 
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onKeyMultiple10237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onKeyMultiple10237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10238; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent10238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onTouchEvent10238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent10239; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent10239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onTrackballEvent10239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged10240; 
		public override void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onWindowFocusChanged10240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onWindowFocusChanged10240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10241; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow10241); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onAttachedToWindow10241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10242; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow10242); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onDetachedFromWindow10242); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent10243; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent10243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _dispatchPopulateAccessibilityEvent10243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu10244; 
		protected override void onCreateContextMenu(android.view.ContextMenu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onCreateContextMenu10244, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onCreateContextMenu10244, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity10245; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setGravity10245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setGravity10245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick10246; 
		public override bool performLongClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _performLongClick10246); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _performLongClick10246); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10247; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onFocusChanged10247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onFocusChanged10247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartTemporaryDetach10248; 
		public override void onStartTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onStartTemporaryDetach10248); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onStartTemporaryDetach10248); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishTemporaryDetach10249; 
		public override void onFinishTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onFinishTemporaryDetach10249); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onFinishTemporaryDetach10249); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyShortcut10250; 
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onKeyShortcut10250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onKeyShortcut10250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCheckIsTextEditor10251; 
		public override bool onCheckIsTextEditor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onCheckIsTextEditor10251); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onCheckIsTextEditor10251); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection10252; 
		public override android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, _onCreateInputConnection10252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _onCreateInputConnection10252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelLongPress10253; 
		public override void cancelLongPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _cancelLongPress10253); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _cancelLongPress10253); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect10254; 
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _getFocusedRect10254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _getFocusedRect10254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll10255; 
		public override void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _computeScroll10255); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _computeScroll10255); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength10256; 
		protected override float getLeftFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallFloatMethod(this, _getLeftFadingEdgeStrength10256); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.TextView.staticClass, _getLeftFadingEdgeStrength10256); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength10257; 
		protected override float getRightFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallFloatMethod(this, _getRightFadingEdgeStrength10257); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.TextView.staticClass, _getRightFadingEdgeStrength10257); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange10258; 
		protected override int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollRange10258); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _computeHorizontalScrollRange10258); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange10259; 
		protected override int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollRange10259); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _computeVerticalScrollRange10259); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent10260; 
		protected override int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollExtent10260); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _computeVerticalScrollExtent10260); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw10261; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onDraw10261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onDraw10261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPaddingOffsetRequired10262; 
		protected override bool isPaddingOffsetRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _isPaddingOffsetRequired10262); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _isPaddingOffsetRequired10262); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftPaddingOffset10263; 
		protected override int getLeftPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getLeftPaddingOffset10263); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getLeftPaddingOffset10263); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightPaddingOffset10264; 
		protected override int getRightPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getRightPaddingOffset10264); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getRightPaddingOffset10264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPaddingOffset10265; 
		protected override int getTopPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getTopPaddingOffset10265); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getTopPaddingOffset10265); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPaddingOffset10266; 
		protected override int getBottomPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getBottomPaddingOffset10266); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getBottomPaddingOffset10266); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable10267; 
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _invalidateDrawable10267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _invalidateDrawable10267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable10268; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _verifyDrawable10268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _verifyDrawable10268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged10269; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _drawableStateChanged10269); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _drawableStateChanged10269); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding10270; 
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setPadding10270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setPadding10270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelected10271; 
		public override void setSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setSelected10271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setSelected10271, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline10272; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getBaseline10272); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getBaseline10272); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10273; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onMeasure10273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onMeasure10273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface10274; 
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTypeface10274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTypeface10274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface10275; 
		public virtual void setTypeface(android.graphics.Typeface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTypeface10275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTypeface10275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultEditable10276; 
		protected virtual bool getDefaultEditable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _getDefaultEditable10276); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _getDefaultEditable10276); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultMovementMethod10277; 
		protected virtual android.text.method.MovementMethod getDefaultMovementMethod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, _getDefaultMovementMethod10277)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getDefaultMovementMethod10277)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEditableText10278; 
		public virtual android.text.Editable getEditableText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, _getEditableText10278)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getEditableText10278)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineHeight10279; 
		public virtual int getLineHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getLineHeight10279); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getLineHeight10279); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyListener10280; 
		public virtual android.text.method.KeyListener getKeyListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.KeyListener>(@__env, @__env.CallObjectMethodPtr(this, _getKeyListener10280)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.KeyListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getKeyListener10280)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyListener10281; 
		public virtual void setKeyListener(android.text.method.KeyListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setKeyListener10281, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setKeyListener10281, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMovementMethod10282; 
		public virtual android.text.method.MovementMethod getMovementMethod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, _getMovementMethod10282)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getMovementMethod10282)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMovementMethod10283; 
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMovementMethod10283, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMovementMethod10283, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformationMethod10284; 
		public virtual android.text.method.TransformationMethod getTransformationMethod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.TransformationMethod>(@__env, @__env.CallObjectMethodPtr(this, _getTransformationMethod10284)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.TransformationMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getTransformationMethod10284)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTransformationMethod10285; 
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTransformationMethod10285, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTransformationMethod10285, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingTop10286; 
		public virtual int getCompoundPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getCompoundPaddingTop10286); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getCompoundPaddingTop10286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingBottom10287; 
		public virtual int getCompoundPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getCompoundPaddingBottom10287); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getCompoundPaddingBottom10287); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingLeft10288; 
		public virtual int getCompoundPaddingLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getCompoundPaddingLeft10288); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getCompoundPaddingLeft10288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingRight10289; 
		public virtual int getCompoundPaddingRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getCompoundPaddingRight10289); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getCompoundPaddingRight10289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedPaddingTop10290; 
		public virtual int getExtendedPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getExtendedPaddingTop10290); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getExtendedPaddingTop10290); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedPaddingBottom10291; 
		public virtual int getExtendedPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getExtendedPaddingBottom10291); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getExtendedPaddingBottom10291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingLeft10292; 
		public virtual int getTotalPaddingLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getTotalPaddingLeft10292); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getTotalPaddingLeft10292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingRight10293; 
		public virtual int getTotalPaddingRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getTotalPaddingRight10293); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getTotalPaddingRight10293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingTop10294; 
		public virtual int getTotalPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getTotalPaddingTop10294); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getTotalPaddingTop10294); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingBottom10295; 
		public virtual int getTotalPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getTotalPaddingBottom10295); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getTotalPaddingBottom10295); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawables10296; 
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setCompoundDrawables10296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setCompoundDrawables10296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablesWithIntrinsicBounds10297; 
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setCompoundDrawablesWithIntrinsicBounds10297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setCompoundDrawablesWithIntrinsicBounds10297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablesWithIntrinsicBounds10298; 
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setCompoundDrawablesWithIntrinsicBounds10298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setCompoundDrawablesWithIntrinsicBounds10298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundDrawables10299; 
		public virtual android.graphics.drawable.Drawable[] getCompoundDrawables() 
		{ 
			if (GetType() == typeof(android.widget.TextView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getCompoundDrawables10299)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getCompoundDrawables10299)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablePadding10300; 
		public virtual void setCompoundDrawablePadding(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setCompoundDrawablePadding10300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setCompoundDrawablePadding10300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundDrawablePadding10301; 
		public virtual int getCompoundDrawablePadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getCompoundDrawablePadding10301); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getCompoundDrawablePadding10301); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAutoLinkMask10302; 
		public virtual int getAutoLinkMask() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getAutoLinkMask10302); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getAutoLinkMask10302); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextAppearance10303; 
		public virtual void setTextAppearance(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextAppearance10303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextAppearance10303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize10304; 
		public virtual float getTextSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallFloatMethod(this, _getTextSize10304); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.TextView.staticClass, _getTextSize10304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize10305; 
		public virtual void setTextSize(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextSize10305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextSize10305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize10306; 
		public virtual void setTextSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextSize10306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextSize10306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextScaleX10307; 
		public virtual float getTextScaleX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallFloatMethod(this, _getTextScaleX10307); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.TextView.staticClass, _getTextScaleX10307); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextScaleX10308; 
		public virtual void setTextScaleX(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextScaleX10308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextScaleX10308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTypeface10309; 
		public virtual android.graphics.Typeface getTypeface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, _getTypeface10309)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getTypeface10309)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor10310; 
		public virtual void setTextColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextColor10310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextColor10310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor10311; 
		public virtual void setTextColor(android.content.res.ColorStateList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextColor10311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextColor10311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextColors10312; 
		public virtual android.content.res.ColorStateList getTextColors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getTextColors10312)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getTextColors10312)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextColors10313; 
		public static android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.staticClass, _getTextColors10313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTextColor10314; 
		public virtual int getCurrentTextColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getCurrentTextColor10314); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getCurrentTextColor10314); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHighlightColor10315; 
		public virtual void setHighlightColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setHighlightColor10315, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setHighlightColor10315, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShadowLayer10316; 
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setShadowLayer10316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setShadowLayer10316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaint10317; 
		public virtual android.text.TextPaint getPaint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallObjectMethodPtr(this, _getPaint10317)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getPaint10317)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutoLinkMask10318; 
		public virtual void setAutoLinkMask(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setAutoLinkMask10318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setAutoLinkMask10318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinksClickable10319; 
		public virtual void setLinksClickable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setLinksClickable10319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setLinksClickable10319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLinksClickable10320; 
		public virtual bool getLinksClickable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _getLinksClickable10320); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _getLinksClickable10320); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrls10321; 
		public virtual android.text.style.URLSpan[] getUrls() 
		{ 
			if (GetType() == typeof(android.widget.TextView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getUrls10321)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getUrls10321)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHintTextColor10322; 
		public virtual void setHintTextColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setHintTextColor10322, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setHintTextColor10322, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHintTextColor10323; 
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setHintTextColor10323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setHintTextColor10323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHintTextColors10324; 
		public virtual android.content.res.ColorStateList getHintTextColors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getHintTextColors10324)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getHintTextColors10324)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentHintTextColor10325; 
		public virtual int getCurrentHintTextColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getCurrentHintTextColor10325); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getCurrentHintTextColor10325); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinkTextColor10326; 
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setLinkTextColor10326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setLinkTextColor10326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinkTextColor10327; 
		public virtual void setLinkTextColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setLinkTextColor10327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setLinkTextColor10327, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLinkTextColors10328; 
		public virtual android.content.res.ColorStateList getLinkTextColors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getLinkTextColors10328)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getLinkTextColors10328)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGravity10329; 
		public virtual int getGravity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getGravity10329); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getGravity10329); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaintFlags10330; 
		public virtual int getPaintFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getPaintFlags10330); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getPaintFlags10330); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPaintFlags10331; 
		public virtual void setPaintFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setPaintFlags10331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setPaintFlags10331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontallyScrolling10332; 
		public virtual void setHorizontallyScrolling(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setHorizontallyScrolling10332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setHorizontallyScrolling10332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinLines10333; 
		public virtual void setMinLines(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMinLines10333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMinLines10333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinHeight10334; 
		public virtual void setMinHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMinHeight10334, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMinHeight10334, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxLines10335; 
		public virtual void setMaxLines(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMaxLines10335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMaxLines10335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxHeight10336; 
		public virtual void setMaxHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMaxHeight10336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMaxHeight10336, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLines10337; 
		public virtual void setLines(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setLines10337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setLines10337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHeight10338; 
		public virtual void setHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setHeight10338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setHeight10338, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinEms10339; 
		public virtual void setMinEms(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMinEms10339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMinEms10339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinWidth10340; 
		public virtual void setMinWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMinWidth10340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMinWidth10340, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxEms10341; 
		public virtual void setMaxEms(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMaxEms10341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMaxEms10341, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxWidth10342; 
		public virtual void setMaxWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMaxWidth10342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMaxWidth10342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEms10343; 
		public virtual void setEms(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setEms10343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setEms10343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWidth10344; 
		public virtual void setWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setWidth10344, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setWidth10344, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLineSpacing10345; 
		public virtual void setLineSpacing(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setLineSpacing10345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setLineSpacing10345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFreezesText10346; 
		public virtual void setFreezesText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setFreezesText10346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setFreezesText10346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFreezesText10347; 
		public virtual bool getFreezesText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _getFreezesText10347); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _getFreezesText10347); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEditableFactory10348; 
		public virtual void setEditableFactory(android.text.Editable_Factory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setEditableFactory10348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setEditableFactory10348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpannableFactory10349; 
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setSpannableFactory10349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setSpannableFactory10349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextKeepState10350; 
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextKeepState10350, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextKeepState10350, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextKeepState10351; 
		public virtual void setTextKeepState(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setTextKeepState10351, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setTextKeepState10351, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHint10352; 
		public virtual void setHint(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setHint10352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setHint10352, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHint10353; 
		public virtual void setHint(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setHint10353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setHint10353, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHint10354; 
		public virtual java.lang.CharSequence getHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getHint10354)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getHint10354)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputType10355; 
		public virtual void setInputType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setInputType10355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setInputType10355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRawInputType10356; 
		public virtual void setRawInputType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setRawInputType10356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setRawInputType10356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType10357; 
		public virtual int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getInputType10357); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getInputType10357); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImeOptions10358; 
		public virtual void setImeOptions(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setImeOptions10358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setImeOptions10358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImeOptions10359; 
		public virtual int getImeOptions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getImeOptions10359); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getImeOptions10359); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImeActionLabel10360; 
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setImeActionLabel10360, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setImeActionLabel10360, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImeActionLabel10361; 
		public virtual java.lang.CharSequence getImeActionLabel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getImeActionLabel10361)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getImeActionLabel10361)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImeActionId10362; 
		public virtual int getImeActionId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getImeActionId10362); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getImeActionId10362); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnEditorActionListener10363; 
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setOnEditorActionListener10363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setOnEditorActionListener10363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEditorAction10364; 
		public virtual void onEditorAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onEditorAction10364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onEditorAction10364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPrivateImeOptions10365; 
		public virtual void setPrivateImeOptions(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setPrivateImeOptions10365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setPrivateImeOptions10365, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrivateImeOptions10366; 
		public virtual java.lang.String getPrivateImeOptions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPrivateImeOptions10366)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getPrivateImeOptions10366)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputExtras10367; 
		public virtual void setInputExtras(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setInputExtras10367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setInputExtras10367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputExtras10368; 
		public virtual android.os.Bundle getInputExtras(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getInputExtras10368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getInputExtras10368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getError10369; 
		public virtual java.lang.CharSequence getError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getError10369)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getError10369)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFrame10370; 
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _setFrame10370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _setFrame10370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilters10371; 
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setFilters10371, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setFilters10371, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilters10372; 
		public virtual android.text.InputFilter[] getFilters() 
		{ 
			if (GetType() == typeof(android.widget.TextView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getFilters10372)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getFilters10372)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPreDraw10373; 
		public virtual bool onPreDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onPreDraw10373); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onPreDraw10373); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount10374; 
		public virtual int getLineCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getLineCount10374); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getLineCount10374); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineBounds10375; 
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getLineBounds10375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getLineBounds10375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractText10376; 
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _extractText10376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _extractText10376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractedText10377; 
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setExtractedText10377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setExtractedText10377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCommitCompletion10378; 
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onCommitCompletion10378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onCommitCompletion10378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit10379; 
		public virtual void beginBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _beginBatchEdit10379); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _beginBatchEdit10379); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit10380; 
		public virtual void endBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _endBatchEdit10380); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _endBatchEdit10380); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBeginBatchEdit10381; 
		public virtual void onBeginBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onBeginBatchEdit10381); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onBeginBatchEdit10381); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEndBatchEdit10382; 
		public virtual void onEndBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onEndBatchEdit10382); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onEndBatchEdit10382); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrivateIMECommand10383; 
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onPrivateIMECommand10383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onPrivateIMECommand10383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIncludeFontPadding10384; 
		public virtual void setIncludeFontPadding(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setIncludeFontPadding10384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setIncludeFontPadding10384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bringPointIntoView10385; 
		public virtual bool bringPointIntoView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _bringPointIntoView10385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _bringPointIntoView10385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveCursorToVisibleOffset10386; 
		public virtual bool moveCursorToVisibleOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _moveCursorToVisibleOffset10386); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _moveCursorToVisibleOffset10386); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionStart10387; 
		public virtual int getSelectionStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getSelectionStart10387); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getSelectionStart10387); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionEnd10388; 
		public virtual int getSelectionEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallIntMethod(this, _getSelectionEnd10388); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TextView.staticClass, _getSelectionEnd10388); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSelection10389; 
		public virtual bool hasSelection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _hasSelection10389); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _hasSelection10389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSingleLine10390; 
		public virtual void setSingleLine() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setSingleLine10390); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setSingleLine10390); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSingleLine10391; 
		public virtual void setSingleLine(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setSingleLine10391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setSingleLine10391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEllipsize10392; 
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setEllipsize10392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setEllipsize10392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMarqueeRepeatLimit10393; 
		public virtual void setMarqueeRepeatLimit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setMarqueeRepeatLimit10393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setMarqueeRepeatLimit10393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsize10394; 
		public virtual android.text.TextUtils.TruncateAt getEllipsize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallObjectMethodPtr(this, _getEllipsize10394)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TextView.staticClass, _getEllipsize10394)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectAllOnFocus10395; 
		public virtual void setSelectAllOnFocus(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setSelectAllOnFocus10395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setSelectAllOnFocus10395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCursorVisible10396; 
		public virtual void setCursorVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setCursorVisible10396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setCursorVisible10396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged10397; 
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onTextChanged10397, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onTextChanged10397, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSelectionChanged10398; 
		protected virtual void onSelectionChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _onSelectionChanged10398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _onSelectionChanged10398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTextChangedListener10399; 
		public virtual void addTextChangedListener(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _addTextChangedListener10399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _addTextChangedListener10399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeTextChangedListener10400; 
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _removeTextChangedListener10400, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _removeTextChangedListener10400, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearComposingText10401; 
		public virtual void clearComposingText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _clearComposingText10401); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _clearComposingText10401); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _didTouchFocusSelect10402; 
		public virtual bool didTouchFocusSelect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _didTouchFocusSelect10402); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _didTouchFocusSelect10402); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScroller10403; 
		public virtual void setScroller(android.widget.Scroller arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				@__env.CallVoidMethod(this, _setScroller10403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TextView.staticClass, _setScroller10403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextColor10404; 
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, _getTextColor10404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputMethodTarget10405; 
		public virtual bool isInputMethodTarget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _isInputMethodTarget10405); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _isInputMethodTarget10405); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextContextMenuItem10406; 
		public virtual bool onTextContextMenuItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TextView)) 
				return @__env.CallBooleanMethod(this, _onTextContextMenuItem10406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TextView.staticClass, _onTextContextMenuItem10406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextView10407; 
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TextView.staticClass, _TextView10407, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextView10408; 
		public TextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TextView.staticClass, _TextView10408, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextView10409; 
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TextView.staticClass, _TextView10409, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TextView.staticClass = @__class; 
			global::android.widget.TextView._append10220 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._append10221 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V"); 
			global::android.widget.TextView._length10222 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "length", "()I"); 
			global::android.widget.TextView._debug10223 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "debug", "(I)V"); 
			global::android.widget.TextView._setError10224 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._setError10225 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setText10226 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(I)V"); 
			global::android.widget.TextView._setText10227 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setText10228 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V"); 
			global::android.widget.TextView._setText10229 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "([CII)V"); 
			global::android.widget.TextView._setText10230 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V"); 
			global::android.widget.TextView._getText10231 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._getLayout10232 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;"); 
			global::android.widget.TextView._onRestoreInstanceState10233 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.TextView._onSaveInstanceState10234 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.TextView._onKeyDown10235 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onKeyUp10236 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onKeyMultiple10237 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onTouchEvent10238 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.TextView._onTrackballEvent10239 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.TextView._onWindowFocusChanged10240 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.widget.TextView._onAttachedToWindow10241 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.TextView._onDetachedFromWindow10242 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.TextView._dispatchPopulateAccessibilityEvent10243 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.TextView._onCreateContextMenu10244 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V"); 
			global::android.widget.TextView._setGravity10245 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setGravity", "(I)V"); 
			global::android.widget.TextView._performLongClick10246 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "performLongClick", "()Z"); 
			global::android.widget.TextView._onFocusChanged10247 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.TextView._onStartTemporaryDetach10248 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V"); 
			global::android.widget.TextView._onFinishTemporaryDetach10249 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V"); 
			global::android.widget.TextView._onKeyShortcut10250 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onCheckIsTextEditor10251 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z"); 
			global::android.widget.TextView._onCreateInputConnection10252 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;"); 
			global::android.widget.TextView._cancelLongPress10253 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "cancelLongPress", "()V"); 
			global::android.widget.TextView._getFocusedRect10254 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V"); 
			global::android.widget.TextView._computeScroll10255 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeScroll", "()V"); 
			global::android.widget.TextView._getLeftFadingEdgeStrength10256 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F"); 
			global::android.widget.TextView._getRightFadingEdgeStrength10257 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F"); 
			global::android.widget.TextView._computeHorizontalScrollRange10258 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.widget.TextView._computeVerticalScrollRange10259 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.widget.TextView._computeVerticalScrollExtent10260 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.widget.TextView._onDraw10261 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.TextView._isPaddingOffsetRequired10262 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z"); 
			global::android.widget.TextView._getLeftPaddingOffset10263 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I"); 
			global::android.widget.TextView._getRightPaddingOffset10264 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I"); 
			global::android.widget.TextView._getTopPaddingOffset10265 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I"); 
			global::android.widget.TextView._getBottomPaddingOffset10266 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I"); 
			global::android.widget.TextView._invalidateDrawable10267 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._verifyDrawable10268 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.TextView._drawableStateChanged10269 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.TextView._setPadding10270 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPadding", "(IIII)V"); 
			global::android.widget.TextView._setSelected10271 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSelected", "(Z)V"); 
			global::android.widget.TextView._getBaseline10272 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getBaseline", "()I"); 
			global::android.widget.TextView._onMeasure10273 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.TextView._setTypeface10274 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V"); 
			global::android.widget.TextView._setTypeface10275 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V"); 
			global::android.widget.TextView._getDefaultEditable10276 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z"); 
			global::android.widget.TextView._getDefaultMovementMethod10277 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;"); 
			global::android.widget.TextView._getEditableText10278 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;"); 
			global::android.widget.TextView._getLineHeight10279 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineHeight", "()I"); 
			global::android.widget.TextView._getKeyListener10280 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;"); 
			global::android.widget.TextView._setKeyListener10281 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V"); 
			global::android.widget.TextView._getMovementMethod10282 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;"); 
			global::android.widget.TextView._setMovementMethod10283 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V"); 
			global::android.widget.TextView._getTransformationMethod10284 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;"); 
			global::android.widget.TextView._setTransformationMethod10285 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V"); 
			global::android.widget.TextView._getCompoundPaddingTop10286 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I"); 
			global::android.widget.TextView._getCompoundPaddingBottom10287 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I"); 
			global::android.widget.TextView._getCompoundPaddingLeft10288 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I"); 
			global::android.widget.TextView._getCompoundPaddingRight10289 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I"); 
			global::android.widget.TextView._getExtendedPaddingTop10290 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I"); 
			global::android.widget.TextView._getExtendedPaddingBottom10291 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I"); 
			global::android.widget.TextView._getTotalPaddingLeft10292 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I"); 
			global::android.widget.TextView._getTotalPaddingRight10293 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I"); 
			global::android.widget.TextView._getTotalPaddingTop10294 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I"); 
			global::android.widget.TextView._getTotalPaddingBottom10295 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I"); 
			global::android.widget.TextView._setCompoundDrawables10296 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds10297 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds10298 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V"); 
			global::android.widget.TextView._getCompoundDrawables10299 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.TextView._setCompoundDrawablePadding10300 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V"); 
			global::android.widget.TextView._getCompoundDrawablePadding10301 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I"); 
			global::android.widget.TextView._getAutoLinkMask10302 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I"); 
			global::android.widget.TextView._setTextAppearance10303 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V"); 
			global::android.widget.TextView._getTextSize10304 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextSize", "()F"); 
			global::android.widget.TextView._setTextSize10305 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextSize", "(IF)V"); 
			global::android.widget.TextView._setTextSize10306 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextSize", "(F)V"); 
			global::android.widget.TextView._getTextScaleX10307 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextScaleX", "()F"); 
			global::android.widget.TextView._setTextScaleX10308 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V"); 
			global::android.widget.TextView._getTypeface10309 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;"); 
			global::android.widget.TextView._setTextColor10310 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextColor", "(I)V"); 
			global::android.widget.TextView._setTextColor10311 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V"); 
			global::android.widget.TextView._getTextColors10312 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getTextColors10313 = @__env.GetStaticMethodID(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getCurrentTextColor10314 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I"); 
			global::android.widget.TextView._setHighlightColor10315 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V"); 
			global::android.widget.TextView._setShadowLayer10316 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V"); 
			global::android.widget.TextView._getPaint10317 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;"); 
			global::android.widget.TextView._setAutoLinkMask10318 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V"); 
			global::android.widget.TextView._setLinksClickable10319 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V"); 
			global::android.widget.TextView._getLinksClickable10320 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLinksClickable", "()Z"); 
			global::android.widget.TextView._getUrls10321 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;"); 
			global::android.widget.TextView._setHintTextColor10322 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V"); 
			global::android.widget.TextView._setHintTextColor10323 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V"); 
			global::android.widget.TextView._getHintTextColors10324 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getCurrentHintTextColor10325 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I"); 
			global::android.widget.TextView._setLinkTextColor10326 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V"); 
			global::android.widget.TextView._setLinkTextColor10327 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V"); 
			global::android.widget.TextView._getLinkTextColors10328 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getGravity10329 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getGravity", "()I"); 
			global::android.widget.TextView._getPaintFlags10330 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPaintFlags", "()I"); 
			global::android.widget.TextView._setPaintFlags10331 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V"); 
			global::android.widget.TextView._setHorizontallyScrolling10332 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V"); 
			global::android.widget.TextView._setMinLines10333 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinLines", "(I)V"); 
			global::android.widget.TextView._setMinHeight10334 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinHeight", "(I)V"); 
			global::android.widget.TextView._setMaxLines10335 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxLines", "(I)V"); 
			global::android.widget.TextView._setMaxHeight10336 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V"); 
			global::android.widget.TextView._setLines10337 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLines", "(I)V"); 
			global::android.widget.TextView._setHeight10338 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHeight", "(I)V"); 
			global::android.widget.TextView._setMinEms10339 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinEms", "(I)V"); 
			global::android.widget.TextView._setMinWidth10340 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinWidth", "(I)V"); 
			global::android.widget.TextView._setMaxEms10341 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxEms", "(I)V"); 
			global::android.widget.TextView._setMaxWidth10342 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V"); 
			global::android.widget.TextView._setEms10343 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEms", "(I)V"); 
			global::android.widget.TextView._setWidth10344 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setWidth", "(I)V"); 
			global::android.widget.TextView._setLineSpacing10345 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V"); 
			global::android.widget.TextView._setFreezesText10346 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V"); 
			global::android.widget.TextView._getFreezesText10347 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFreezesText", "()Z"); 
			global::android.widget.TextView._setEditableFactory10348 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V"); 
			global::android.widget.TextView._setSpannableFactory10349 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V"); 
			global::android.widget.TextView._setTextKeepState10350 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V"); 
			global::android.widget.TextView._setTextKeepState10351 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setHint10352 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setHint10353 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHint", "(I)V"); 
			global::android.widget.TextView._getHint10354 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._setInputType10355 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setInputType", "(I)V"); 
			global::android.widget.TextView._setRawInputType10356 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setRawInputType", "(I)V"); 
			global::android.widget.TextView._getInputType10357 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getInputType", "()I"); 
			global::android.widget.TextView._setImeOptions10358 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setImeOptions", "(I)V"); 
			global::android.widget.TextView._getImeOptions10359 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeOptions", "()I"); 
			global::android.widget.TextView._setImeActionLabel10360 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V"); 
			global::android.widget.TextView._getImeActionLabel10361 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._getImeActionId10362 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeActionId", "()I"); 
			global::android.widget.TextView._setOnEditorActionListener10363 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V"); 
			global::android.widget.TextView._onEditorAction10364 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onEditorAction", "(I)V"); 
			global::android.widget.TextView._setPrivateImeOptions10365 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V"); 
			global::android.widget.TextView._getPrivateImeOptions10366 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;"); 
			global::android.widget.TextView._setInputExtras10367 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setInputExtras", "(I)V"); 
			global::android.widget.TextView._getInputExtras10368 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;"); 
			global::android.widget.TextView._getError10369 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._setFrame10370 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z"); 
			global::android.widget.TextView._setFilters10371 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V"); 
			global::android.widget.TextView._getFilters10372 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;"); 
			global::android.widget.TextView._onPreDraw10373 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onPreDraw", "()Z"); 
			global::android.widget.TextView._getLineCount10374 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineCount", "()I"); 
			global::android.widget.TextView._getLineBounds10375 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I"); 
			global::android.widget.TextView._extractText10376 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z"); 
			global::android.widget.TextView._setExtractedText10377 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V"); 
			global::android.widget.TextView._onCommitCompletion10378 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.widget.TextView._beginBatchEdit10379 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "beginBatchEdit", "()V"); 
			global::android.widget.TextView._endBatchEdit10380 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "endBatchEdit", "()V"); 
			global::android.widget.TextView._onBeginBatchEdit10381 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V"); 
			global::android.widget.TextView._onEndBatchEdit10382 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V"); 
			global::android.widget.TextView._onPrivateIMECommand10383 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z"); 
			global::android.widget.TextView._setIncludeFontPadding10384 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V"); 
			global::android.widget.TextView._bringPointIntoView10385 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z"); 
			global::android.widget.TextView._moveCursorToVisibleOffset10386 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z"); 
			global::android.widget.TextView._getSelectionStart10387 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getSelectionStart", "()I"); 
			global::android.widget.TextView._getSelectionEnd10388 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getSelectionEnd", "()I"); 
			global::android.widget.TextView._hasSelection10389 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "hasSelection", "()Z"); 
			global::android.widget.TextView._setSingleLine10390 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSingleLine", "()V"); 
			global::android.widget.TextView._setSingleLine10391 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V"); 
			global::android.widget.TextView._setEllipsize10392 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V"); 
			global::android.widget.TextView._setMarqueeRepeatLimit10393 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V"); 
			global::android.widget.TextView._getEllipsize10394 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;"); 
			global::android.widget.TextView._setSelectAllOnFocus10395 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V"); 
			global::android.widget.TextView._setCursorVisible10396 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V"); 
			global::android.widget.TextView._onTextChanged10397 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.widget.TextView._onSelectionChanged10398 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V"); 
			global::android.widget.TextView._addTextChangedListener10399 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.TextView._removeTextChangedListener10400 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.TextView._clearComposingText10401 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "clearComposingText", "()V"); 
			global::android.widget.TextView._didTouchFocusSelect10402 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z"); 
			global::android.widget.TextView._setScroller10403 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V"); 
			global::android.widget.TextView._getTextColor10404 = @__env.GetStaticMethodID(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I"); 
			global::android.widget.TextView._isInputMethodTarget10405 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z"); 
			global::android.widget.TextView._onTextContextMenuItem10406 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z"); 
			global::android.widget.TextView._TextView10407 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TextView._TextView10408 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TextView._TextView10409 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
