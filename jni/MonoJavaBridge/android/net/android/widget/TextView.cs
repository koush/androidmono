namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TextView : android.view.View, android.view.ViewTreeObserver.OnPreDrawListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TextView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TextView.BufferType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf11015; 
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView.BufferType>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._valueOf11015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values11016; 
			public static global::android.widget.TextView.BufferType[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._values11016)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _EDITABLE11017; 
			public static global::android.widget.TextView.BufferType EDITABLE
			{ 
				get 
				{ 
					return default(global::android.widget.TextView.BufferType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL11018; 
			public static global::android.widget.TextView.BufferType NORMAL
			{ 
				get 
				{ 
					return default(global::android.widget.TextView.BufferType); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SPANNABLE11019; 
			public static global::android.widget.TextView.BufferType SPANNABLE
			{ 
				get 
				{ 
					return default(global::android.widget.TextView.BufferType); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TextView.BufferType.staticClass = @__class; 
				global::android.widget.TextView.BufferType._valueOf11015 = @__env.GetStaticMethodID(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;"); 
				global::android.widget.TextView.BufferType._values11016 = @__env.GetStaticMethodID(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnEditorActionListener 
		{ 
			bool onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2); 
		} 

		public partial class OnEditorActionListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnEditorActionListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnEditorActionListener : java.lang.Object, OnEditorActionListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnEditorActionListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TextView.__OnEditorActionListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TextView.__OnEditorActionListener(@__env); 
				} 
			} 
			internal __OnEditorActionListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onEditorAction11020; 
			 bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.widget.TextView.__OnEditorActionListener._onEditorAction11020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.__OnEditorActionListener.staticClass, global::android.widget.TextView.__OnEditorActionListener._onEditorAction11020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TextView.__OnEditorActionListener.staticClass = @__class; 
				global::android.widget.TextView.__OnEditorActionListener._onEditorAction11020 = @__env.GetMethodID(global::android.widget.TextView.__OnEditorActionListener.staticClass, "android.widget.TextView.OnEditorActionListener.onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SavedState : android.view.View.BaseSavedState
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SavedState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TextView.SavedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString11021; 
			public override global::java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView.SavedState._toString11021)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._toString11021)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel11022; 
			public override void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.widget.TextView.SavedState._writeToParcel11022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._writeToParcel11022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR11023; 
			public static global::android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(global::android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TextView.SavedState.staticClass = @__class; 
				global::android.widget.TextView.SavedState._toString11021 = @__env.GetMethodID(global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.widget.TextView.SavedState._writeToParcel11022 = @__env.GetMethodID(global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append11024; 
		public virtual void append(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._append11024, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._append11024, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append11025; 
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._append11025, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._append11025, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length11026; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._length11026); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._length11026); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _debug11027; 
		public virtual void debug(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._debug11027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._debug11027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setError11028; 
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setError11028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError11028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setError11029; 
		public virtual void setError(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setError11029, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError11029, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText11030; 
		public virtual void setText(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11030, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11030, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText11031; 
		public virtual void setText(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11031, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11031, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText11032; 
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11032, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11032, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText11033; 
		public virtual void setText(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11033, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11033, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setText11034; 
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11034, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11034, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getText11035; 
		public virtual global::java.lang.CharSequence getText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getText11035)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getText11035)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayout11036; 
		public virtual global::android.text.Layout getLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getLayout11036)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLayout11036)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState11037; 
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onRestoreInstanceState11037, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onRestoreInstanceState11037, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState11038; 
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._onSaveInstanceState11038)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSaveInstanceState11038)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown11039; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyDown11039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyDown11039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp11040; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyUp11040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyUp11040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple11041; 
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyMultiple11041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyMultiple11041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11042; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onTouchEvent11042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTouchEvent11042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent11043; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onTrackballEvent11043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTrackballEvent11043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged11044; 
		public override void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onWindowFocusChanged11044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onWindowFocusChanged11044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow11045; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onAttachedToWindow11045); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onAttachedToWindow11045); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow11046; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onDetachedFromWindow11046); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDetachedFromWindow11046); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent11047; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._dispatchPopulateAccessibilityEvent11047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._dispatchPopulateAccessibilityEvent11047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu11048; 
		protected override void onCreateContextMenu(android.view.ContextMenu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onCreateContextMenu11048, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateContextMenu11048, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity11049; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setGravity11049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setGravity11049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick11050; 
		public override bool performLongClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._performLongClick11050); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._performLongClick11050); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged11051; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onFocusChanged11051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFocusChanged11051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartTemporaryDetach11052; 
		public override void onStartTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onStartTemporaryDetach11052); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onStartTemporaryDetach11052); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishTemporaryDetach11053; 
		public override void onFinishTemporaryDetach() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onFinishTemporaryDetach11053); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFinishTemporaryDetach11053); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyShortcut11054; 
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyShortcut11054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyShortcut11054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCheckIsTextEditor11055; 
		public override bool onCheckIsTextEditor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onCheckIsTextEditor11055); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCheckIsTextEditor11055); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection11056; 
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._onCreateInputConnection11056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateInputConnection11056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelLongPress11057; 
		public override void cancelLongPress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._cancelLongPress11057); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._cancelLongPress11057); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect11058; 
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._getFocusedRect11058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFocusedRect11058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll11059; 
		public override void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._computeScroll11059); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeScroll11059); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength11060; 
		protected override float getLeftFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getLeftFadingEdgeStrength11060); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftFadingEdgeStrength11060); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength11061; 
		protected override float getRightFadingEdgeStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getRightFadingEdgeStrength11061); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightFadingEdgeStrength11061); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange11062; 
		protected override int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._computeHorizontalScrollRange11062); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeHorizontalScrollRange11062); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange11063; 
		protected override int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._computeVerticalScrollRange11063); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollRange11063); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent11064; 
		protected override int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._computeVerticalScrollExtent11064); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollExtent11064); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw11065; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onDraw11065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDraw11065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPaddingOffsetRequired11066; 
		protected override bool isPaddingOffsetRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._isPaddingOffsetRequired11066); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._isPaddingOffsetRequired11066); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeftPaddingOffset11067; 
		protected override int getLeftPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLeftPaddingOffset11067); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftPaddingOffset11067); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRightPaddingOffset11068; 
		protected override int getRightPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getRightPaddingOffset11068); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightPaddingOffset11068); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPaddingOffset11069; 
		protected override int getTopPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTopPaddingOffset11069); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTopPaddingOffset11069); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPaddingOffset11070; 
		protected override int getBottomPaddingOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getBottomPaddingOffset11070); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBottomPaddingOffset11070); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable11071; 
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._invalidateDrawable11071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._invalidateDrawable11071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable11072; 
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._verifyDrawable11072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._verifyDrawable11072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged11073; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._drawableStateChanged11073); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._drawableStateChanged11073); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding11074; 
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setPadding11074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPadding11074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelected11075; 
		public override void setSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSelected11075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelected11075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline11076; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getBaseline11076); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBaseline11076); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11077; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onMeasure11077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onMeasure11077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface11078; 
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTypeface11078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface11078, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface11079; 
		public virtual void setTypeface(android.graphics.Typeface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTypeface11079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface11079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultEditable11080; 
		protected virtual bool getDefaultEditable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._getDefaultEditable11080); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultEditable11080); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultMovementMethod11081; 
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getDefaultMovementMethod11081)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultMovementMethod11081)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEditableText11082; 
		public virtual global::android.text.Editable getEditableText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getEditableText11082)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEditableText11082)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineHeight11083; 
		public virtual int getLineHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLineHeight11083); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineHeight11083); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKeyListener11084; 
		public virtual global::android.text.method.KeyListener getKeyListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.KeyListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getKeyListener11084)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.KeyListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getKeyListener11084)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeyListener11085; 
		public virtual void setKeyListener(android.text.method.KeyListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setKeyListener11085, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setKeyListener11085, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMovementMethod11086; 
		public virtual global::android.text.method.MovementMethod getMovementMethod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getMovementMethod11086)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getMovementMethod11086)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMovementMethod11087; 
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMovementMethod11087, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMovementMethod11087, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformationMethod11088; 
		public virtual global::android.text.method.TransformationMethod getTransformationMethod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.TransformationMethod>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getTransformationMethod11088)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.TransformationMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTransformationMethod11088)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTransformationMethod11089; 
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTransformationMethod11089, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTransformationMethod11089, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingTop11090; 
		public virtual int getCompoundPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingTop11090); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingTop11090); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingBottom11091; 
		public virtual int getCompoundPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingBottom11091); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingBottom11091); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingLeft11092; 
		public virtual int getCompoundPaddingLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingLeft11092); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingLeft11092); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingRight11093; 
		public virtual int getCompoundPaddingRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingRight11093); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingRight11093); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedPaddingTop11094; 
		public virtual int getExtendedPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getExtendedPaddingTop11094); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingTop11094); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedPaddingBottom11095; 
		public virtual int getExtendedPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getExtendedPaddingBottom11095); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingBottom11095); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingLeft11096; 
		public virtual int getTotalPaddingLeft() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingLeft11096); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingLeft11096); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingRight11097; 
		public virtual int getTotalPaddingRight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingRight11097); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingRight11097); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingTop11098; 
		public virtual int getTotalPaddingTop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingTop11098); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingTop11098); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingBottom11099; 
		public virtual int getTotalPaddingBottom() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingBottom11099); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingBottom11099); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawables11100; 
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawables11100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawables11100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablesWithIntrinsicBounds11101; 
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablesWithIntrinsicBounds11102; 
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundDrawables11103; 
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getCompoundDrawables11103)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawables11103)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablePadding11104; 
		public virtual void setCompoundDrawablePadding(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawablePadding11104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablePadding11104, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundDrawablePadding11105; 
		public virtual int getCompoundDrawablePadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundDrawablePadding11105); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawablePadding11105); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAutoLinkMask11106; 
		public virtual int getAutoLinkMask() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getAutoLinkMask11106); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getAutoLinkMask11106); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextAppearance11107; 
		public virtual void setTextAppearance(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextAppearance11107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextAppearance11107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize11108; 
		public virtual float getTextSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getTextSize11108); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextSize11108); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize11109; 
		public virtual void setTextSize(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextSize11109, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize11109, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize11110; 
		public virtual void setTextSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextSize11110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize11110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextScaleX11111; 
		public virtual float getTextScaleX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getTextScaleX11111); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextScaleX11111); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextScaleX11112; 
		public virtual void setTextScaleX(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextScaleX11112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextScaleX11112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTypeface11113; 
		public virtual global::android.graphics.Typeface getTypeface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getTypeface11113)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTypeface11113)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor11114; 
		public virtual void setTextColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextColor11114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor11114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor11115; 
		public virtual void setTextColor(android.content.res.ColorStateList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextColor11115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor11115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextColors11116; 
		public virtual global::android.content.res.ColorStateList getTextColors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getTextColors11116)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors11116)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextColors11117; 
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors11117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTextColor11118; 
		public virtual int getCurrentTextColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCurrentTextColor11118); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentTextColor11118); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHighlightColor11119; 
		public virtual void setHighlightColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHighlightColor11119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHighlightColor11119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShadowLayer11120; 
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setShadowLayer11120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setShadowLayer11120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaint11121; 
		public virtual global::android.text.TextPaint getPaint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getPaint11121)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaint11121)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutoLinkMask11122; 
		public virtual void setAutoLinkMask(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setAutoLinkMask11122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setAutoLinkMask11122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinksClickable11123; 
		public virtual void setLinksClickable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLinksClickable11123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinksClickable11123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLinksClickable11124; 
		public virtual bool getLinksClickable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._getLinksClickable11124); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinksClickable11124); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrls11125; 
		public virtual global::android.text.style.URLSpan[] getUrls() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getUrls11125)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getUrls11125)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHintTextColor11126; 
		public virtual void setHintTextColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHintTextColor11126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor11126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHintTextColor11127; 
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHintTextColor11127, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor11127, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHintTextColors11128; 
		public virtual global::android.content.res.ColorStateList getHintTextColors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getHintTextColors11128)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHintTextColors11128)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentHintTextColor11129; 
		public virtual int getCurrentHintTextColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCurrentHintTextColor11129); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentHintTextColor11129); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinkTextColor11130; 
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLinkTextColor11130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor11130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLinkTextColor11131; 
		public virtual void setLinkTextColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLinkTextColor11131, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor11131, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLinkTextColors11132; 
		public virtual global::android.content.res.ColorStateList getLinkTextColors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getLinkTextColors11132)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinkTextColors11132)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGravity11133; 
		public virtual int getGravity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getGravity11133); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getGravity11133); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaintFlags11134; 
		public virtual int getPaintFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getPaintFlags11134); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaintFlags11134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPaintFlags11135; 
		public virtual void setPaintFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setPaintFlags11135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPaintFlags11135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontallyScrolling11136; 
		public virtual void setHorizontallyScrolling(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHorizontallyScrolling11136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHorizontallyScrolling11136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinLines11137; 
		public virtual void setMinLines(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinLines11137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinLines11137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinHeight11138; 
		public virtual void setMinHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinHeight11138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinHeight11138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxLines11139; 
		public virtual void setMaxLines(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxLines11139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxLines11139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxHeight11140; 
		public virtual void setMaxHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxHeight11140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxHeight11140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLines11141; 
		public virtual void setLines(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLines11141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLines11141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHeight11142; 
		public virtual void setHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHeight11142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHeight11142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinEms11143; 
		public virtual void setMinEms(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinEms11143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinEms11143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinWidth11144; 
		public virtual void setMinWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinWidth11144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinWidth11144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxEms11145; 
		public virtual void setMaxEms(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxEms11145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxEms11145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxWidth11146; 
		public virtual void setMaxWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxWidth11146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxWidth11146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEms11147; 
		public virtual void setEms(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setEms11147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEms11147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWidth11148; 
		public virtual void setWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setWidth11148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setWidth11148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLineSpacing11149; 
		public virtual void setLineSpacing(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLineSpacing11149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLineSpacing11149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFreezesText11150; 
		public virtual void setFreezesText(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setFreezesText11150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFreezesText11150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFreezesText11151; 
		public virtual bool getFreezesText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._getFreezesText11151); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFreezesText11151); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEditableFactory11152; 
		public virtual void setEditableFactory(android.text.Editable_Factory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setEditableFactory11152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEditableFactory11152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpannableFactory11153; 
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSpannableFactory11153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSpannableFactory11153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextKeepState11154; 
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextKeepState11154, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState11154, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextKeepState11155; 
		public virtual void setTextKeepState(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextKeepState11155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState11155, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHint11156; 
		public virtual void setHint(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHint11156, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint11156, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHint11157; 
		public virtual void setHint(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHint11157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint11157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHint11158; 
		public virtual global::java.lang.CharSequence getHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getHint11158)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHint11158)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputType11159; 
		public virtual void setInputType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setInputType11159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputType11159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRawInputType11160; 
		public virtual void setRawInputType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setRawInputType11160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setRawInputType11160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType11161; 
		public virtual int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getInputType11161); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputType11161); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImeOptions11162; 
		public virtual void setImeOptions(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setImeOptions11162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeOptions11162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImeOptions11163; 
		public virtual int getImeOptions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getImeOptions11163); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeOptions11163); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImeActionLabel11164; 
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setImeActionLabel11164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeActionLabel11164, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImeActionLabel11165; 
		public virtual global::java.lang.CharSequence getImeActionLabel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getImeActionLabel11165)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionLabel11165)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getImeActionId11166; 
		public virtual int getImeActionId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getImeActionId11166); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionId11166); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnEditorActionListener11167; 
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setOnEditorActionListener11167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setOnEditorActionListener11167, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEditorAction11168; 
		public virtual void onEditorAction(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onEditorAction11168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEditorAction11168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPrivateImeOptions11169; 
		public virtual void setPrivateImeOptions(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setPrivateImeOptions11169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPrivateImeOptions11169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrivateImeOptions11170; 
		public virtual global::java.lang.String getPrivateImeOptions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getPrivateImeOptions11170)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPrivateImeOptions11170)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInputExtras11171; 
		public virtual void setInputExtras(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setInputExtras11171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputExtras11171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputExtras11172; 
		public virtual global::android.os.Bundle getInputExtras(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getInputExtras11172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputExtras11172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getError11173; 
		public virtual global::java.lang.CharSequence getError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getError11173)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getError11173)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFrame11174; 
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._setFrame11174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFrame11174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilters11175; 
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setFilters11175, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFilters11175, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFilters11176; 
		public virtual global::android.text.InputFilter[] getFilters() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getFilters11176)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFilters11176)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPreDraw11177; 
		public virtual bool onPreDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onPreDraw11177); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPreDraw11177); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount11178; 
		public virtual int getLineCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLineCount11178); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineCount11178); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineBounds11179; 
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLineBounds11179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineBounds11179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractText11180; 
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._extractText11180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._extractText11180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtractedText11181; 
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setExtractedText11181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setExtractedText11181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCommitCompletion11182; 
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onCommitCompletion11182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCommitCompletion11182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit11183; 
		public virtual void beginBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._beginBatchEdit11183); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._beginBatchEdit11183); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit11184; 
		public virtual void endBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._endBatchEdit11184); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._endBatchEdit11184); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBeginBatchEdit11185; 
		public virtual void onBeginBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onBeginBatchEdit11185); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onBeginBatchEdit11185); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onEndBatchEdit11186; 
		public virtual void onEndBatchEdit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onEndBatchEdit11186); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEndBatchEdit11186); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrivateIMECommand11187; 
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onPrivateIMECommand11187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPrivateIMECommand11187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIncludeFontPadding11188; 
		public virtual void setIncludeFontPadding(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setIncludeFontPadding11188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setIncludeFontPadding11188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bringPointIntoView11189; 
		public virtual bool bringPointIntoView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._bringPointIntoView11189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._bringPointIntoView11189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveCursorToVisibleOffset11190; 
		public virtual bool moveCursorToVisibleOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._moveCursorToVisibleOffset11190); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._moveCursorToVisibleOffset11190); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionStart11191; 
		public virtual int getSelectionStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getSelectionStart11191); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionStart11191); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionEnd11192; 
		public virtual int getSelectionEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.widget.TextView._getSelectionEnd11192); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionEnd11192); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSelection11193; 
		public virtual bool hasSelection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._hasSelection11193); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._hasSelection11193); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSingleLine11194; 
		public virtual void setSingleLine() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSingleLine11194); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine11194); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSingleLine11195; 
		public virtual void setSingleLine(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSingleLine11195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine11195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEllipsize11196; 
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setEllipsize11196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEllipsize11196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMarqueeRepeatLimit11197; 
		public virtual void setMarqueeRepeatLimit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMarqueeRepeatLimit11197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMarqueeRepeatLimit11197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsize11198; 
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getEllipsize11198)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEllipsize11198)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectAllOnFocus11199; 
		public virtual void setSelectAllOnFocus(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSelectAllOnFocus11199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelectAllOnFocus11199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCursorVisible11200; 
		public virtual void setCursorVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCursorVisible11200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCursorVisible11200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged11201; 
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onTextChanged11201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextChanged11201, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSelectionChanged11202; 
		protected virtual void onSelectionChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._onSelectionChanged11202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSelectionChanged11202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTextChangedListener11203; 
		public virtual void addTextChangedListener(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._addTextChangedListener11203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._addTextChangedListener11203, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeTextChangedListener11204; 
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._removeTextChangedListener11204, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._removeTextChangedListener11204, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearComposingText11205; 
		public virtual void clearComposingText() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._clearComposingText11205); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._clearComposingText11205); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _didTouchFocusSelect11206; 
		public virtual bool didTouchFocusSelect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._didTouchFocusSelect11206); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._didTouchFocusSelect11206); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScroller11207; 
		public virtual void setScroller(android.widget.Scroller arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.widget.TextView._setScroller11207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setScroller11207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextColor11208; 
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColor11208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInputMethodTarget11209; 
		public virtual bool isInputMethodTarget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._isInputMethodTarget11209); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._isInputMethodTarget11209); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTextContextMenuItem11210; 
		public virtual bool onTextContextMenuItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onTextContextMenuItem11210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextContextMenuItem11210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextView11211; 
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView11211, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextView11212; 
		public TextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView11212, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextView11213; 
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView11213, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TextView.staticClass = @__class; 
			global::android.widget.TextView._append11024 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._append11025 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V"); 
			global::android.widget.TextView._length11026 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "length", "()I"); 
			global::android.widget.TextView._debug11027 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "debug", "(I)V"); 
			global::android.widget.TextView._setError11028 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._setError11029 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setText11030 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(I)V"); 
			global::android.widget.TextView._setText11031 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setText11032 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V"); 
			global::android.widget.TextView._setText11033 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "([CII)V"); 
			global::android.widget.TextView._setText11034 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V"); 
			global::android.widget.TextView._getText11035 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._getLayout11036 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;"); 
			global::android.widget.TextView._onRestoreInstanceState11037 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"); 
			global::android.widget.TextView._onSaveInstanceState11038 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;"); 
			global::android.widget.TextView._onKeyDown11039 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onKeyUp11040 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onKeyMultiple11041 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onTouchEvent11042 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.TextView._onTrackballEvent11043 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.widget.TextView._onWindowFocusChanged11044 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.widget.TextView._onAttachedToWindow11045 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.widget.TextView._onDetachedFromWindow11046 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.TextView._dispatchPopulateAccessibilityEvent11047 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.TextView._onCreateContextMenu11048 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V"); 
			global::android.widget.TextView._setGravity11049 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setGravity", "(I)V"); 
			global::android.widget.TextView._performLongClick11050 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "performLongClick", "()Z"); 
			global::android.widget.TextView._onFocusChanged11051 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.widget.TextView._onStartTemporaryDetach11052 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V"); 
			global::android.widget.TextView._onFinishTemporaryDetach11053 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V"); 
			global::android.widget.TextView._onKeyShortcut11054 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.widget.TextView._onCheckIsTextEditor11055 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z"); 
			global::android.widget.TextView._onCreateInputConnection11056 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;"); 
			global::android.widget.TextView._cancelLongPress11057 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "cancelLongPress", "()V"); 
			global::android.widget.TextView._getFocusedRect11058 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V"); 
			global::android.widget.TextView._computeScroll11059 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeScroll", "()V"); 
			global::android.widget.TextView._getLeftFadingEdgeStrength11060 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F"); 
			global::android.widget.TextView._getRightFadingEdgeStrength11061 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F"); 
			global::android.widget.TextView._computeHorizontalScrollRange11062 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.widget.TextView._computeVerticalScrollRange11063 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.widget.TextView._computeVerticalScrollExtent11064 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.widget.TextView._onDraw11065 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.widget.TextView._isPaddingOffsetRequired11066 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z"); 
			global::android.widget.TextView._getLeftPaddingOffset11067 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I"); 
			global::android.widget.TextView._getRightPaddingOffset11068 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I"); 
			global::android.widget.TextView._getTopPaddingOffset11069 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I"); 
			global::android.widget.TextView._getBottomPaddingOffset11070 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I"); 
			global::android.widget.TextView._invalidateDrawable11071 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._verifyDrawable11072 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z"); 
			global::android.widget.TextView._drawableStateChanged11073 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "drawableStateChanged", "()V"); 
			global::android.widget.TextView._setPadding11074 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPadding", "(IIII)V"); 
			global::android.widget.TextView._setSelected11075 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSelected", "(Z)V"); 
			global::android.widget.TextView._getBaseline11076 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getBaseline", "()I"); 
			global::android.widget.TextView._onMeasure11077 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.TextView._setTypeface11078 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V"); 
			global::android.widget.TextView._setTypeface11079 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V"); 
			global::android.widget.TextView._getDefaultEditable11080 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z"); 
			global::android.widget.TextView._getDefaultMovementMethod11081 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;"); 
			global::android.widget.TextView._getEditableText11082 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;"); 
			global::android.widget.TextView._getLineHeight11083 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineHeight", "()I"); 
			global::android.widget.TextView._getKeyListener11084 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;"); 
			global::android.widget.TextView._setKeyListener11085 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V"); 
			global::android.widget.TextView._getMovementMethod11086 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;"); 
			global::android.widget.TextView._setMovementMethod11087 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V"); 
			global::android.widget.TextView._getTransformationMethod11088 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;"); 
			global::android.widget.TextView._setTransformationMethod11089 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V"); 
			global::android.widget.TextView._getCompoundPaddingTop11090 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I"); 
			global::android.widget.TextView._getCompoundPaddingBottom11091 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I"); 
			global::android.widget.TextView._getCompoundPaddingLeft11092 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I"); 
			global::android.widget.TextView._getCompoundPaddingRight11093 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I"); 
			global::android.widget.TextView._getExtendedPaddingTop11094 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I"); 
			global::android.widget.TextView._getExtendedPaddingBottom11095 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I"); 
			global::android.widget.TextView._getTotalPaddingLeft11096 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I"); 
			global::android.widget.TextView._getTotalPaddingRight11097 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I"); 
			global::android.widget.TextView._getTotalPaddingTop11098 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I"); 
			global::android.widget.TextView._getTotalPaddingBottom11099 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I"); 
			global::android.widget.TextView._setCompoundDrawables11100 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11101 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11102 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V"); 
			global::android.widget.TextView._getCompoundDrawables11103 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;"); 
			global::android.widget.TextView._setCompoundDrawablePadding11104 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V"); 
			global::android.widget.TextView._getCompoundDrawablePadding11105 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I"); 
			global::android.widget.TextView._getAutoLinkMask11106 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I"); 
			global::android.widget.TextView._setTextAppearance11107 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V"); 
			global::android.widget.TextView._getTextSize11108 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextSize", "()F"); 
			global::android.widget.TextView._setTextSize11109 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextSize", "(IF)V"); 
			global::android.widget.TextView._setTextSize11110 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextSize", "(F)V"); 
			global::android.widget.TextView._getTextScaleX11111 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextScaleX", "()F"); 
			global::android.widget.TextView._setTextScaleX11112 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V"); 
			global::android.widget.TextView._getTypeface11113 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;"); 
			global::android.widget.TextView._setTextColor11114 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextColor", "(I)V"); 
			global::android.widget.TextView._setTextColor11115 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V"); 
			global::android.widget.TextView._getTextColors11116 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getTextColors11117 = @__env.GetStaticMethodID(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getCurrentTextColor11118 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I"); 
			global::android.widget.TextView._setHighlightColor11119 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V"); 
			global::android.widget.TextView._setShadowLayer11120 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V"); 
			global::android.widget.TextView._getPaint11121 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;"); 
			global::android.widget.TextView._setAutoLinkMask11122 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V"); 
			global::android.widget.TextView._setLinksClickable11123 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V"); 
			global::android.widget.TextView._getLinksClickable11124 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLinksClickable", "()Z"); 
			global::android.widget.TextView._getUrls11125 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;"); 
			global::android.widget.TextView._setHintTextColor11126 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V"); 
			global::android.widget.TextView._setHintTextColor11127 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V"); 
			global::android.widget.TextView._getHintTextColors11128 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getCurrentHintTextColor11129 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I"); 
			global::android.widget.TextView._setLinkTextColor11130 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V"); 
			global::android.widget.TextView._setLinkTextColor11131 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V"); 
			global::android.widget.TextView._getLinkTextColors11132 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;"); 
			global::android.widget.TextView._getGravity11133 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getGravity", "()I"); 
			global::android.widget.TextView._getPaintFlags11134 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPaintFlags", "()I"); 
			global::android.widget.TextView._setPaintFlags11135 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V"); 
			global::android.widget.TextView._setHorizontallyScrolling11136 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V"); 
			global::android.widget.TextView._setMinLines11137 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinLines", "(I)V"); 
			global::android.widget.TextView._setMinHeight11138 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinHeight", "(I)V"); 
			global::android.widget.TextView._setMaxLines11139 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxLines", "(I)V"); 
			global::android.widget.TextView._setMaxHeight11140 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V"); 
			global::android.widget.TextView._setLines11141 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLines", "(I)V"); 
			global::android.widget.TextView._setHeight11142 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHeight", "(I)V"); 
			global::android.widget.TextView._setMinEms11143 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinEms", "(I)V"); 
			global::android.widget.TextView._setMinWidth11144 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinWidth", "(I)V"); 
			global::android.widget.TextView._setMaxEms11145 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxEms", "(I)V"); 
			global::android.widget.TextView._setMaxWidth11146 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V"); 
			global::android.widget.TextView._setEms11147 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEms", "(I)V"); 
			global::android.widget.TextView._setWidth11148 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setWidth", "(I)V"); 
			global::android.widget.TextView._setLineSpacing11149 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V"); 
			global::android.widget.TextView._setFreezesText11150 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V"); 
			global::android.widget.TextView._getFreezesText11151 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFreezesText", "()Z"); 
			global::android.widget.TextView._setEditableFactory11152 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V"); 
			global::android.widget.TextView._setSpannableFactory11153 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V"); 
			global::android.widget.TextView._setTextKeepState11154 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V"); 
			global::android.widget.TextView._setTextKeepState11155 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setHint11156 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.TextView._setHint11157 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHint", "(I)V"); 
			global::android.widget.TextView._getHint11158 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._setInputType11159 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setInputType", "(I)V"); 
			global::android.widget.TextView._setRawInputType11160 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setRawInputType", "(I)V"); 
			global::android.widget.TextView._getInputType11161 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getInputType", "()I"); 
			global::android.widget.TextView._setImeOptions11162 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setImeOptions", "(I)V"); 
			global::android.widget.TextView._getImeOptions11163 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeOptions", "()I"); 
			global::android.widget.TextView._setImeActionLabel11164 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V"); 
			global::android.widget.TextView._getImeActionLabel11165 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._getImeActionId11166 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeActionId", "()I"); 
			global::android.widget.TextView._setOnEditorActionListener11167 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V"); 
			global::android.widget.TextView._onEditorAction11168 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onEditorAction", "(I)V"); 
			global::android.widget.TextView._setPrivateImeOptions11169 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V"); 
			global::android.widget.TextView._getPrivateImeOptions11170 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;"); 
			global::android.widget.TextView._setInputExtras11171 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setInputExtras", "(I)V"); 
			global::android.widget.TextView._getInputExtras11172 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;"); 
			global::android.widget.TextView._getError11173 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;"); 
			global::android.widget.TextView._setFrame11174 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z"); 
			global::android.widget.TextView._setFilters11175 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V"); 
			global::android.widget.TextView._getFilters11176 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;"); 
			global::android.widget.TextView._onPreDraw11177 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onPreDraw", "()Z"); 
			global::android.widget.TextView._getLineCount11178 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineCount", "()I"); 
			global::android.widget.TextView._getLineBounds11179 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I"); 
			global::android.widget.TextView._extractText11180 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z"); 
			global::android.widget.TextView._setExtractedText11181 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V"); 
			global::android.widget.TextView._onCommitCompletion11182 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V"); 
			global::android.widget.TextView._beginBatchEdit11183 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "beginBatchEdit", "()V"); 
			global::android.widget.TextView._endBatchEdit11184 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "endBatchEdit", "()V"); 
			global::android.widget.TextView._onBeginBatchEdit11185 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V"); 
			global::android.widget.TextView._onEndBatchEdit11186 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V"); 
			global::android.widget.TextView._onPrivateIMECommand11187 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z"); 
			global::android.widget.TextView._setIncludeFontPadding11188 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V"); 
			global::android.widget.TextView._bringPointIntoView11189 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z"); 
			global::android.widget.TextView._moveCursorToVisibleOffset11190 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z"); 
			global::android.widget.TextView._getSelectionStart11191 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getSelectionStart", "()I"); 
			global::android.widget.TextView._getSelectionEnd11192 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getSelectionEnd", "()I"); 
			global::android.widget.TextView._hasSelection11193 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "hasSelection", "()Z"); 
			global::android.widget.TextView._setSingleLine11194 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSingleLine", "()V"); 
			global::android.widget.TextView._setSingleLine11195 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V"); 
			global::android.widget.TextView._setEllipsize11196 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V"); 
			global::android.widget.TextView._setMarqueeRepeatLimit11197 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V"); 
			global::android.widget.TextView._getEllipsize11198 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;"); 
			global::android.widget.TextView._setSelectAllOnFocus11199 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V"); 
			global::android.widget.TextView._setCursorVisible11200 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V"); 
			global::android.widget.TextView._onTextChanged11201 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"); 
			global::android.widget.TextView._onSelectionChanged11202 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V"); 
			global::android.widget.TextView._addTextChangedListener11203 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.TextView._removeTextChangedListener11204 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V"); 
			global::android.widget.TextView._clearComposingText11205 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "clearComposingText", "()V"); 
			global::android.widget.TextView._didTouchFocusSelect11206 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z"); 
			global::android.widget.TextView._setScroller11207 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V"); 
			global::android.widget.TextView._getTextColor11208 = @__env.GetStaticMethodID(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I"); 
			global::android.widget.TextView._isInputMethodTarget11209 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z"); 
			global::android.widget.TextView._onTextContextMenuItem11210 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z"); 
			global::android.widget.TextView._TextView11211 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TextView._TextView11212 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TextView._TextView11213 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
