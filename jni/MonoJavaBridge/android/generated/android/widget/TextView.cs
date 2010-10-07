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
			internal static global::net.sf.jni4net.jni.MethodId _values11732;
			public static global::android.widget.TextView.BufferType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._values11732));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf11733;
			public static global::android.widget.TextView.BufferType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TextView.BufferType>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.BufferType.staticClass, global::android.widget.TextView.BufferType._valueOf11733, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _EDITABLE11734;
			public static global::android.widget.TextView.BufferType EDITABLE
			{
				get
				{
					return default(global::android.widget.TextView.BufferType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NORMAL11735;
			public static global::android.widget.TextView.BufferType NORMAL
			{
				get
				{
					return default(global::android.widget.TextView.BufferType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SPANNABLE11736;
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
				global::android.widget.TextView.BufferType._values11732 = @__env.GetStaticMethodID(global::android.widget.TextView.BufferType.staticClass, "values", "()[Landroid/widget/TextView/BufferType;");
				global::android.widget.TextView.BufferType._valueOf11733 = @__env.GetStaticMethodID(global::android.widget.TextView.BufferType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;");
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
			internal static global::net.sf.jni4net.jni.MethodId _onEditorAction11737;
			 bool android.widget.TextView.OnEditorActionListener.onEditorAction(android.widget.TextView arg0, int arg1, android.view.KeyEvent arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.widget.TextView.__OnEditorActionListener._onEditorAction11737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.__OnEditorActionListener.staticClass, global::android.widget.TextView.__OnEditorActionListener._onEditorAction11737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.TextView.__OnEditorActionListener.staticClass = @__class;
				global::android.widget.TextView.__OnEditorActionListener._onEditorAction11737 = @__env.GetMethodID(global::android.widget.TextView.__OnEditorActionListener.staticClass, "android.widget.TextView.OnEditorActionListener.onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z");
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
			internal static global::net.sf.jni4net.jni.MethodId _toString11738;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView.SavedState._toString11738));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._toString11738));
			}
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel11739;
			public override void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.TextView.SavedState._writeToParcel11739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.SavedState.staticClass, global::android.widget.TextView.SavedState._writeToParcel11739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR11740;
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
				global::android.widget.TextView.SavedState._toString11738 = @__env.GetMethodID(global::android.widget.TextView.SavedState.staticClass, "toString", "()Ljava/lang/String;");
				global::android.widget.TextView.SavedState._writeToParcel11739 = @__env.GetMethodID(global::android.widget.TextView.SavedState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _append11741;
		public virtual void append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._append11741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._append11741, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void append(string arg0)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append11742;
		public virtual void append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._append11742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._append11742, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		public void append(string arg0, int arg1, int arg2)
		{
			append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _length11743;
		public virtual int length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._length11743);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._length11743);
		}
		internal static global::net.sf.jni4net.jni.MethodId _debug11744;
		public virtual void debug(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._debug11744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._debug11744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setError11745;
		public virtual void setError(java.lang.CharSequence arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setError11745, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError11745, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		public void setError(string arg0, android.graphics.drawable.Drawable arg1)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setError11746;
		public virtual void setError(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setError11746, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setError11746, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setError(string arg0)
		{
			setError((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText11747;
		public virtual void setText(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText11748;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText11749;
		public virtual void setText(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		public void setText(string arg0, android.widget.TextView.BufferType arg1)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText11750;
		public virtual void setText(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11750, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11750, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText11751;
		public virtual void setText(int arg0, android.widget.TextView.BufferType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setText11751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setText11751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText11752;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getText11752));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getText11752));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayout11753;
		public virtual global::android.text.Layout getLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getLayout11753));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLayout11753));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState11754;
		public virtual new void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onRestoreInstanceState11754, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onRestoreInstanceState11754, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState11755;
		public virtual new global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._onSaveInstanceState11755));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSaveInstanceState11755));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown11756;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyDown11756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyDown11756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp11757;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyUp11757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyUp11757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple11758;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyMultiple11758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyMultiple11758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent11759;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onTouchEvent11759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTouchEvent11759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent11760;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onTrackballEvent11760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTrackballEvent11760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged11761;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onWindowFocusChanged11761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onWindowFocusChanged11761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow11762;
		protected override void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onAttachedToWindow11762);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onAttachedToWindow11762);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow11763;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onDetachedFromWindow11763);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDetachedFromWindow11763);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent11764;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._dispatchPopulateAccessibilityEvent11764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._dispatchPopulateAccessibilityEvent11764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu11765;
		protected override void onCreateContextMenu(android.view.ContextMenu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onCreateContextMenu11765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateContextMenu11765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGravity11766;
		public virtual void setGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setGravity11766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setGravity11766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick11767;
		public override bool performLongClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._performLongClick11767);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._performLongClick11767);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged11768;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onFocusChanged11768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFocusChanged11768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStartTemporaryDetach11769;
		public override void onStartTemporaryDetach() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onStartTemporaryDetach11769);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onStartTemporaryDetach11769);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishTemporaryDetach11770;
		public override void onFinishTemporaryDetach() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onFinishTemporaryDetach11770);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onFinishTemporaryDetach11770);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyShortcut11771;
		public override bool onKeyShortcut(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onKeyShortcut11771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onKeyShortcut11771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCheckIsTextEditor11772;
		public override bool onCheckIsTextEditor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onCheckIsTextEditor11772);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCheckIsTextEditor11772);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection11773;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._onCreateInputConnection11773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCreateInputConnection11773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelLongPress11774;
		public override void cancelLongPress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._cancelLongPress11774);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._cancelLongPress11774);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedRect11775;
		public override void getFocusedRect(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._getFocusedRect11775, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFocusedRect11775, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll11776;
		public override void computeScroll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._computeScroll11776);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeScroll11776);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeftFadingEdgeStrength11777;
		protected override float getLeftFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getLeftFadingEdgeStrength11777);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftFadingEdgeStrength11777);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRightFadingEdgeStrength11778;
		protected override float getRightFadingEdgeStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getRightFadingEdgeStrength11778);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightFadingEdgeStrength11778);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange11779;
		protected override int computeHorizontalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._computeHorizontalScrollRange11779);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeHorizontalScrollRange11779);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange11780;
		protected override int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._computeVerticalScrollRange11780);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollRange11780);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent11781;
		protected override int computeVerticalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._computeVerticalScrollExtent11781);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._computeVerticalScrollExtent11781);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw11782;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onDraw11782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onDraw11782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isPaddingOffsetRequired11783;
		protected override bool isPaddingOffsetRequired() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._isPaddingOffsetRequired11783);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._isPaddingOffsetRequired11783);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLeftPaddingOffset11784;
		protected override int getLeftPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLeftPaddingOffset11784);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLeftPaddingOffset11784);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRightPaddingOffset11785;
		protected override int getRightPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getRightPaddingOffset11785);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getRightPaddingOffset11785);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopPaddingOffset11786;
		protected override int getTopPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTopPaddingOffset11786);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTopPaddingOffset11786);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPaddingOffset11787;
		protected override int getBottomPaddingOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getBottomPaddingOffset11787);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBottomPaddingOffset11787);
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable11788;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._invalidateDrawable11788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._invalidateDrawable11788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable11789;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._verifyDrawable11789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._verifyDrawable11789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged11790;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._drawableStateChanged11790);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._drawableStateChanged11790);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPadding11791;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setPadding11791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPadding11791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelected11792;
		public override void setSelected(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSelected11792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelected11792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline11793;
		public override int getBaseline() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getBaseline11793);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getBaseline11793);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11794;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onMeasure11794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onMeasure11794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface11795;
		public virtual void setTypeface(android.graphics.Typeface arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTypeface11795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface11795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTypeface11796;
		public virtual void setTypeface(android.graphics.Typeface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTypeface11796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTypeface11796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultEditable11797;
		protected virtual bool getDefaultEditable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._getDefaultEditable11797);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultEditable11797);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultMovementMethod11798;
		protected virtual global::android.text.method.MovementMethod getDefaultMovementMethod() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getDefaultMovementMethod11798));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getDefaultMovementMethod11798));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEditableText11799;
		public virtual global::android.text.Editable getEditableText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getEditableText11799));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEditableText11799));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineHeight11800;
		public virtual int getLineHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLineHeight11800);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineHeight11800);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKeyListener11801;
		public virtual global::android.text.method.KeyListener getKeyListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.KeyListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getKeyListener11801));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.KeyListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getKeyListener11801));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setKeyListener11802;
		public virtual void setKeyListener(android.text.method.KeyListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setKeyListener11802, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setKeyListener11802, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMovementMethod11803;
		public virtual global::android.text.method.MovementMethod getMovementMethod() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getMovementMethod11803));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.MovementMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getMovementMethod11803));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMovementMethod11804;
		public virtual void setMovementMethod(android.text.method.MovementMethod arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMovementMethod11804, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMovementMethod11804, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransformationMethod11805;
		public virtual global::android.text.method.TransformationMethod getTransformationMethod() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.TransformationMethod>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getTransformationMethod11805));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.method.TransformationMethod>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTransformationMethod11805));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTransformationMethod11806;
		public virtual void setTransformationMethod(android.text.method.TransformationMethod arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTransformationMethod11806, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTransformationMethod11806, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingTop11807;
		public virtual int getCompoundPaddingTop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingTop11807);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingTop11807);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingBottom11808;
		public virtual int getCompoundPaddingBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingBottom11808);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingBottom11808);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingLeft11809;
		public virtual int getCompoundPaddingLeft() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingLeft11809);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingLeft11809);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundPaddingRight11810;
		public virtual int getCompoundPaddingRight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundPaddingRight11810);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundPaddingRight11810);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedPaddingTop11811;
		public virtual int getExtendedPaddingTop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getExtendedPaddingTop11811);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingTop11811);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtendedPaddingBottom11812;
		public virtual int getExtendedPaddingBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getExtendedPaddingBottom11812);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getExtendedPaddingBottom11812);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingLeft11813;
		public virtual int getTotalPaddingLeft() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingLeft11813);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingLeft11813);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingRight11814;
		public virtual int getTotalPaddingRight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingRight11814);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingRight11814);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingTop11815;
		public virtual int getTotalPaddingTop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingTop11815);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingTop11815);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTotalPaddingBottom11816;
		public virtual int getTotalPaddingBottom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getTotalPaddingBottom11816);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTotalPaddingBottom11816);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawables11817;
		public virtual void setCompoundDrawables(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawables11817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawables11817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablesWithIntrinsicBounds11818;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable arg0, android.graphics.drawable.Drawable arg1, android.graphics.drawable.Drawable arg2, android.graphics.drawable.Drawable arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11818, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablesWithIntrinsicBounds11819;
		public virtual void setCompoundDrawablesWithIntrinsicBounds(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundDrawables11820;
		public virtual global::android.graphics.drawable.Drawable[] getCompoundDrawables() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getCompoundDrawables11820));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawables11820));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCompoundDrawablePadding11821;
		public virtual void setCompoundDrawablePadding(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCompoundDrawablePadding11821, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCompoundDrawablePadding11821, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCompoundDrawablePadding11822;
		public virtual int getCompoundDrawablePadding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCompoundDrawablePadding11822);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCompoundDrawablePadding11822);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAutoLinkMask11823;
		public virtual int getAutoLinkMask() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getAutoLinkMask11823);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getAutoLinkMask11823);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextAppearance11824;
		public virtual void setTextAppearance(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextAppearance11824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextAppearance11824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize11825;
		public virtual float getTextSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getTextSize11825);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextSize11825);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize11826;
		public virtual void setTextSize(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextSize11826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize11826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextSize11827;
		public virtual void setTextSize(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextSize11827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextSize11827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextScaleX11828;
		public virtual float getTextScaleX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.TextView._getTextScaleX11828);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextScaleX11828);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextScaleX11829;
		public virtual void setTextScaleX(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextScaleX11829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextScaleX11829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTypeface11830;
		public virtual global::android.graphics.Typeface getTypeface() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getTypeface11830));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTypeface11830));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor11831;
		public virtual void setTextColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextColor11831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor11831, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextColor11832;
		public virtual void setTextColor(android.content.res.ColorStateList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextColor11832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextColor11832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextColors11833;
		public virtual global::android.content.res.ColorStateList getTextColors() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getTextColors11833));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors11833));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextColors11834;
		public static global::android.content.res.ColorStateList getTextColors(android.content.Context arg0, android.content.res.TypedArray arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColors11834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTextColor11835;
		public virtual int getCurrentTextColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCurrentTextColor11835);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentTextColor11835);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHighlightColor11836;
		public virtual void setHighlightColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHighlightColor11836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHighlightColor11836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShadowLayer11837;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setShadowLayer11837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setShadowLayer11837, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaint11838;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getPaint11838));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaint11838));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAutoLinkMask11839;
		public virtual void setAutoLinkMask(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setAutoLinkMask11839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setAutoLinkMask11839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLinksClickable11840;
		public virtual void setLinksClickable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLinksClickable11840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinksClickable11840, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLinksClickable11841;
		public virtual bool getLinksClickable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._getLinksClickable11841);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinksClickable11841);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUrls11842;
		public virtual global::android.text.style.URLSpan[] getUrls() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getUrls11842));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getUrls11842));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHintTextColor11843;
		public virtual void setHintTextColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHintTextColor11843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor11843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHintTextColor11844;
		public virtual void setHintTextColor(android.content.res.ColorStateList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHintTextColor11844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHintTextColor11844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHintTextColors11845;
		public virtual global::android.content.res.ColorStateList getHintTextColors() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getHintTextColors11845));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHintTextColors11845));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentHintTextColor11846;
		public virtual int getCurrentHintTextColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getCurrentHintTextColor11846);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getCurrentHintTextColor11846);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLinkTextColor11847;
		public virtual void setLinkTextColor(android.content.res.ColorStateList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLinkTextColor11847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor11847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLinkTextColor11848;
		public virtual void setLinkTextColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLinkTextColor11848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLinkTextColor11848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLinkTextColors11849;
		public virtual global::android.content.res.ColorStateList getLinkTextColors() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getLinkTextColors11849));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLinkTextColors11849));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGravity11850;
		public virtual int getGravity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getGravity11850);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getGravity11850);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaintFlags11851;
		public virtual int getPaintFlags() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getPaintFlags11851);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPaintFlags11851);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPaintFlags11852;
		public virtual void setPaintFlags(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setPaintFlags11852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPaintFlags11852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontallyScrolling11853;
		public virtual void setHorizontallyScrolling(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHorizontallyScrolling11853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHorizontallyScrolling11853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinLines11854;
		public virtual void setMinLines(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinLines11854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinLines11854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinHeight11855;
		public virtual void setMinHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinHeight11855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinHeight11855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxLines11856;
		public virtual void setMaxLines(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxLines11856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxLines11856, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxHeight11857;
		public virtual void setMaxHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxHeight11857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxHeight11857, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLines11858;
		public virtual void setLines(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLines11858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLines11858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHeight11859;
		public virtual void setHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHeight11859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHeight11859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinEms11860;
		public virtual void setMinEms(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinEms11860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinEms11860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinWidth11861;
		public virtual void setMinWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMinWidth11861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMinWidth11861, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxEms11862;
		public virtual void setMaxEms(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxEms11862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxEms11862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxWidth11863;
		public virtual void setMaxWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMaxWidth11863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMaxWidth11863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEms11864;
		public virtual void setEms(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setEms11864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEms11864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWidth11865;
		public virtual void setWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setWidth11865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setWidth11865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLineSpacing11866;
		public virtual void setLineSpacing(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setLineSpacing11866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setLineSpacing11866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFreezesText11867;
		public virtual void setFreezesText(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setFreezesText11867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFreezesText11867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFreezesText11868;
		public virtual bool getFreezesText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._getFreezesText11868);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFreezesText11868);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEditableFactory11869;
		public virtual void setEditableFactory(android.text.Editable_Factory arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setEditableFactory11869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEditableFactory11869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSpannableFactory11870;
		public virtual void setSpannableFactory(android.text.Spannable_Factory arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSpannableFactory11870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSpannableFactory11870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextKeepState11871;
		public virtual void setTextKeepState(java.lang.CharSequence arg0, android.widget.TextView.BufferType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextKeepState11871, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState11871, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		public void setTextKeepState(string arg0, android.widget.TextView.BufferType arg1)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextKeepState11872;
		public virtual void setTextKeepState(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setTextKeepState11872, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setTextKeepState11872, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTextKeepState(string arg0)
		{
			setTextKeepState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHint11873;
		public virtual void setHint(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHint11873, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint11873, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setHint(string arg0)
		{
			setHint((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHint11874;
		public virtual void setHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setHint11874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setHint11874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHint11875;
		public virtual global::java.lang.CharSequence getHint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getHint11875));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getHint11875));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInputType11876;
		public virtual void setInputType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setInputType11876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputType11876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRawInputType11877;
		public virtual void setRawInputType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setRawInputType11877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setRawInputType11877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType11878;
		public virtual int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getInputType11878);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputType11878);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImeOptions11879;
		public virtual void setImeOptions(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setImeOptions11879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeOptions11879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImeOptions11880;
		public virtual int getImeOptions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getImeOptions11880);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeOptions11880);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImeActionLabel11881;
		public virtual void setImeActionLabel(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setImeActionLabel11881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setImeActionLabel11881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		public void setImeActionLabel(string arg0, int arg1)
		{
			setImeActionLabel((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImeActionLabel11882;
		public virtual global::java.lang.CharSequence getImeActionLabel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getImeActionLabel11882));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionLabel11882));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImeActionId11883;
		public virtual int getImeActionId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getImeActionId11883);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getImeActionId11883);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnEditorActionListener11884;
		public virtual void setOnEditorActionListener(android.widget.TextView.OnEditorActionListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setOnEditorActionListener11884, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setOnEditorActionListener11884, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEditorAction11885;
		public virtual void onEditorAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onEditorAction11885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEditorAction11885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPrivateImeOptions11886;
		public virtual void setPrivateImeOptions(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setPrivateImeOptions11886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setPrivateImeOptions11886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPrivateImeOptions11887;
		public virtual global::java.lang.String getPrivateImeOptions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getPrivateImeOptions11887));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getPrivateImeOptions11887));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInputExtras11888;
		public virtual void setInputExtras(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setInputExtras11888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setInputExtras11888, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputExtras11889;
		public virtual global::android.os.Bundle getInputExtras(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getInputExtras11889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getInputExtras11889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getError11890;
		public virtual global::java.lang.CharSequence getError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getError11890));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getError11890));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFrame11891;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._setFrame11891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFrame11891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilters11892;
		public virtual void setFilters(android.text.InputFilter[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setFilters11892, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setFilters11892, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilters11893;
		public virtual global::android.text.InputFilter[] getFilters() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getFilters11893));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getFilters11893));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPreDraw11894;
		public virtual bool onPreDraw() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onPreDraw11894);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPreDraw11894);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount11895;
		public virtual int getLineCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLineCount11895);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineCount11895);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineBounds11896;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getLineBounds11896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getLineBounds11896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extractText11897;
		public virtual bool extractText(android.view.inputmethod.ExtractedTextRequest arg0, android.view.inputmethod.ExtractedText arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._extractText11897, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._extractText11897, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setExtractedText11898;
		public virtual void setExtractedText(android.view.inputmethod.ExtractedText arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setExtractedText11898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setExtractedText11898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCommitCompletion11899;
		public virtual void onCommitCompletion(android.view.inputmethod.CompletionInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onCommitCompletion11899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onCommitCompletion11899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _beginBatchEdit11900;
		public virtual void beginBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._beginBatchEdit11900);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._beginBatchEdit11900);
		}
		internal static global::net.sf.jni4net.jni.MethodId _endBatchEdit11901;
		public virtual void endBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._endBatchEdit11901);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._endBatchEdit11901);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBeginBatchEdit11902;
		public virtual void onBeginBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onBeginBatchEdit11902);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onBeginBatchEdit11902);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEndBatchEdit11903;
		public virtual void onEndBatchEdit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onEndBatchEdit11903);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onEndBatchEdit11903);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrivateIMECommand11904;
		public virtual bool onPrivateIMECommand(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onPrivateIMECommand11904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onPrivateIMECommand11904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIncludeFontPadding11905;
		public virtual void setIncludeFontPadding(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setIncludeFontPadding11905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setIncludeFontPadding11905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bringPointIntoView11906;
		public virtual bool bringPointIntoView(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._bringPointIntoView11906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._bringPointIntoView11906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveCursorToVisibleOffset11907;
		public virtual bool moveCursorToVisibleOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._moveCursorToVisibleOffset11907);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._moveCursorToVisibleOffset11907);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionStart11908;
		public virtual int getSelectionStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getSelectionStart11908);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionStart11908);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionEnd11909;
		public virtual int getSelectionEnd() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.TextView._getSelectionEnd11909);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getSelectionEnd11909);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasSelection11910;
		public virtual bool hasSelection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._hasSelection11910);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._hasSelection11910);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSingleLine11911;
		public virtual void setSingleLine() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSingleLine11911);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine11911);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSingleLine11912;
		public virtual void setSingleLine(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSingleLine11912, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSingleLine11912, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEllipsize11913;
		public virtual void setEllipsize(android.text.TextUtils.TruncateAt arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setEllipsize11913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setEllipsize11913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMarqueeRepeatLimit11914;
		public virtual void setMarqueeRepeatLimit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setMarqueeRepeatLimit11914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setMarqueeRepeatLimit11914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsize11915;
		public virtual global::android.text.TextUtils.TruncateAt getEllipsize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TextView._getEllipsize11915));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextUtils.TruncateAt>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._getEllipsize11915));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectAllOnFocus11916;
		public virtual void setSelectAllOnFocus(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setSelectAllOnFocus11916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setSelectAllOnFocus11916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCursorVisible11917;
		public virtual void setCursorVisible(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setCursorVisible11917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setCursorVisible11917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTextChanged11918;
		protected virtual void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onTextChanged11918, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextChanged11918, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSelectionChanged11919;
		protected virtual void onSelectionChanged(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._onSelectionChanged11919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onSelectionChanged11919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addTextChangedListener11920;
		public virtual void addTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._addTextChangedListener11920, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._addTextChangedListener11920, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeTextChangedListener11921;
		public virtual void removeTextChangedListener(android.text.TextWatcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._removeTextChangedListener11921, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._removeTextChangedListener11921, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearComposingText11922;
		public virtual void clearComposingText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._clearComposingText11922);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._clearComposingText11922);
		}
		internal static global::net.sf.jni4net.jni.MethodId _didTouchFocusSelect11923;
		public virtual bool didTouchFocusSelect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._didTouchFocusSelect11923);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._didTouchFocusSelect11923);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScroller11924;
		public virtual void setScroller(android.widget.Scroller arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextView._setScroller11924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._setScroller11924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextColor11925;
		public static int getTextColor(android.content.Context arg0, android.content.res.TypedArray arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.widget.TextView.staticClass, global::android.widget.TextView._getTextColor11925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInputMethodTarget11926;
		public virtual bool isInputMethodTarget() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._isInputMethodTarget11926);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._isInputMethodTarget11926);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTextContextMenuItem11927;
		public virtual bool onTextContextMenuItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TextView._onTextContextMenuItem11927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TextView.staticClass, global::android.widget.TextView._onTextContextMenuItem11927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextView11928;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView11928, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextView11929;
		public TextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView11929, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextView11930;
		public TextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TextView.staticClass, global::android.widget.TextView._TextView11930, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.TextView.staticClass = @__class;
			global::android.widget.TextView._append11741 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._append11742 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "append", "(Ljava/lang/CharSequence;II)V");
			global::android.widget.TextView._length11743 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "length", "()I");
			global::android.widget.TextView._debug11744 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "debug", "(I)V");
			global::android.widget.TextView._setError11745 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setError11746 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setError", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText11747 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(I)V");
			global::android.widget.TextView._setText11748 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setText11749 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setText11750 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "([CII)V");
			global::android.widget.TextView._setText11751 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setText", "(ILandroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._getText11752 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getLayout11753 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLayout", "()Landroid/text/Layout;");
			global::android.widget.TextView._onRestoreInstanceState11754 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.TextView._onSaveInstanceState11755 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.TextView._onKeyDown11756 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyUp11757 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onKeyMultiple11758 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onTouchEvent11759 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onTrackballEvent11760 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.TextView._onWindowFocusChanged11761 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.widget.TextView._onAttachedToWindow11762 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.TextView._onDetachedFromWindow11763 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.TextView._dispatchPopulateAccessibilityEvent11764 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.TextView._onCreateContextMenu11765 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.widget.TextView._setGravity11766 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setGravity", "(I)V");
			global::android.widget.TextView._performLongClick11767 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "performLongClick", "()Z");
			global::android.widget.TextView._onFocusChanged11768 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.TextView._onStartTemporaryDetach11769 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onStartTemporaryDetach", "()V");
			global::android.widget.TextView._onFinishTemporaryDetach11770 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onFinishTemporaryDetach", "()V");
			global::android.widget.TextView._onKeyShortcut11771 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.TextView._onCheckIsTextEditor11772 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCheckIsTextEditor", "()Z");
			global::android.widget.TextView._onCreateInputConnection11773 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.widget.TextView._cancelLongPress11774 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "cancelLongPress", "()V");
			global::android.widget.TextView._getFocusedRect11775 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V");
			global::android.widget.TextView._computeScroll11776 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeScroll", "()V");
			global::android.widget.TextView._getLeftFadingEdgeStrength11777 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLeftFadingEdgeStrength", "()F");
			global::android.widget.TextView._getRightFadingEdgeStrength11778 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getRightFadingEdgeStrength", "()F");
			global::android.widget.TextView._computeHorizontalScrollRange11779 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollRange11780 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.TextView._computeVerticalScrollExtent11781 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.TextView._onDraw11782 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.TextView._isPaddingOffsetRequired11783 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "isPaddingOffsetRequired", "()Z");
			global::android.widget.TextView._getLeftPaddingOffset11784 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLeftPaddingOffset", "()I");
			global::android.widget.TextView._getRightPaddingOffset11785 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getRightPaddingOffset", "()I");
			global::android.widget.TextView._getTopPaddingOffset11786 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTopPaddingOffset", "()I");
			global::android.widget.TextView._getBottomPaddingOffset11787 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getBottomPaddingOffset", "()I");
			global::android.widget.TextView._invalidateDrawable11788 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._verifyDrawable11789 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.TextView._drawableStateChanged11790 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.TextView._setPadding11791 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.TextView._setSelected11792 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSelected", "(Z)V");
			global::android.widget.TextView._getBaseline11793 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getBaseline", "()I");
			global::android.widget.TextView._onMeasure11794 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onMeasure", "(II)V");
			global::android.widget.TextView._setTypeface11795 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;I)V");
			global::android.widget.TextView._setTypeface11796 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)V");
			global::android.widget.TextView._getDefaultEditable11797 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getDefaultEditable", "()Z");
			global::android.widget.TextView._getDefaultMovementMethod11798 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._getEditableText11799 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getEditableText", "()Landroid/text/Editable;");
			global::android.widget.TextView._getLineHeight11800 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineHeight", "()I");
			global::android.widget.TextView._getKeyListener11801 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getKeyListener", "()Landroid/text/method/KeyListener;");
			global::android.widget.TextView._setKeyListener11802 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setKeyListener", "(Landroid/text/method/KeyListener;)V");
			global::android.widget.TextView._getMovementMethod11803 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getMovementMethod", "()Landroid/text/method/MovementMethod;");
			global::android.widget.TextView._setMovementMethod11804 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMovementMethod", "(Landroid/text/method/MovementMethod;)V");
			global::android.widget.TextView._getTransformationMethod11805 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTransformationMethod", "()Landroid/text/method/TransformationMethod;");
			global::android.widget.TextView._setTransformationMethod11806 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V");
			global::android.widget.TextView._getCompoundPaddingTop11807 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingTop", "()I");
			global::android.widget.TextView._getCompoundPaddingBottom11808 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingBottom", "()I");
			global::android.widget.TextView._getCompoundPaddingLeft11809 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingLeft", "()I");
			global::android.widget.TextView._getCompoundPaddingRight11810 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundPaddingRight", "()I");
			global::android.widget.TextView._getExtendedPaddingTop11811 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getExtendedPaddingTop", "()I");
			global::android.widget.TextView._getExtendedPaddingBottom11812 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getExtendedPaddingBottom", "()I");
			global::android.widget.TextView._getTotalPaddingLeft11813 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingLeft", "()I");
			global::android.widget.TextView._getTotalPaddingRight11814 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingRight", "()I");
			global::android.widget.TextView._getTotalPaddingTop11815 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingTop", "()I");
			global::android.widget.TextView._getTotalPaddingBottom11816 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTotalPaddingBottom", "()I");
			global::android.widget.TextView._setCompoundDrawables11817 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11818 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.TextView._setCompoundDrawablesWithIntrinsicBounds11819 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablesWithIntrinsicBounds", "(IIII)V");
			global::android.widget.TextView._getCompoundDrawables11820 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;");
			global::android.widget.TextView._setCompoundDrawablePadding11821 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCompoundDrawablePadding", "(I)V");
			global::android.widget.TextView._getCompoundDrawablePadding11822 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCompoundDrawablePadding", "()I");
			global::android.widget.TextView._getAutoLinkMask11823 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getAutoLinkMask", "()I");
			global::android.widget.TextView._setTextAppearance11824 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextAppearance", "(Landroid/content/Context;I)V");
			global::android.widget.TextView._getTextSize11825 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextSize", "()F");
			global::android.widget.TextView._setTextSize11826 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextSize", "(IF)V");
			global::android.widget.TextView._setTextSize11827 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextSize", "(F)V");
			global::android.widget.TextView._getTextScaleX11828 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextScaleX", "()F");
			global::android.widget.TextView._setTextScaleX11829 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextScaleX", "(F)V");
			global::android.widget.TextView._getTypeface11830 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTypeface", "()Landroid/graphics/Typeface;");
			global::android.widget.TextView._setTextColor11831 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextColor", "(I)V");
			global::android.widget.TextView._setTextColor11832 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getTextColors11833 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getTextColors11834 = @__env.GetStaticMethodID(global::android.widget.TextView.staticClass, "getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentTextColor11835 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCurrentTextColor", "()I");
			global::android.widget.TextView._setHighlightColor11836 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHighlightColor", "(I)V");
			global::android.widget.TextView._setShadowLayer11837 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setShadowLayer", "(FFFI)V");
			global::android.widget.TextView._getPaint11838 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.widget.TextView._setAutoLinkMask11839 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setAutoLinkMask", "(I)V");
			global::android.widget.TextView._setLinksClickable11840 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinksClickable", "(Z)V");
			global::android.widget.TextView._getLinksClickable11841 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLinksClickable", "()Z");
			global::android.widget.TextView._getUrls11842 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getUrls", "()[Landroid/text/style/URLSpan;");
			global::android.widget.TextView._setHintTextColor11843 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHintTextColor", "(I)V");
			global::android.widget.TextView._setHintTextColor11844 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHintTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._getHintTextColors11845 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getHintTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getCurrentHintTextColor11846 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getCurrentHintTextColor", "()I");
			global::android.widget.TextView._setLinkTextColor11847 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinkTextColor", "(Landroid/content/res/ColorStateList;)V");
			global::android.widget.TextView._setLinkTextColor11848 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLinkTextColor", "(I)V");
			global::android.widget.TextView._getLinkTextColors11849 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLinkTextColors", "()Landroid/content/res/ColorStateList;");
			global::android.widget.TextView._getGravity11850 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getGravity", "()I");
			global::android.widget.TextView._getPaintFlags11851 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPaintFlags", "()I");
			global::android.widget.TextView._setPaintFlags11852 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPaintFlags", "(I)V");
			global::android.widget.TextView._setHorizontallyScrolling11853 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHorizontallyScrolling", "(Z)V");
			global::android.widget.TextView._setMinLines11854 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinLines", "(I)V");
			global::android.widget.TextView._setMinHeight11855 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinHeight", "(I)V");
			global::android.widget.TextView._setMaxLines11856 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxLines", "(I)V");
			global::android.widget.TextView._setMaxHeight11857 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.TextView._setLines11858 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLines", "(I)V");
			global::android.widget.TextView._setHeight11859 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHeight", "(I)V");
			global::android.widget.TextView._setMinEms11860 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinEms", "(I)V");
			global::android.widget.TextView._setMinWidth11861 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMinWidth", "(I)V");
			global::android.widget.TextView._setMaxEms11862 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxEms", "(I)V");
			global::android.widget.TextView._setMaxWidth11863 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.TextView._setEms11864 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEms", "(I)V");
			global::android.widget.TextView._setWidth11865 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setWidth", "(I)V");
			global::android.widget.TextView._setLineSpacing11866 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setLineSpacing", "(FF)V");
			global::android.widget.TextView._setFreezesText11867 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFreezesText", "(Z)V");
			global::android.widget.TextView._getFreezesText11868 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFreezesText", "()Z");
			global::android.widget.TextView._setEditableFactory11869 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEditableFactory", "(Landroid/text/Editable$Factory;)V");
			global::android.widget.TextView._setSpannableFactory11870 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSpannableFactory", "(Landroid/text/Spannable$Factory;)V");
			global::android.widget.TextView._setTextKeepState11871 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V");
			global::android.widget.TextView._setTextKeepState11872 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setTextKeepState", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint11873 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHint", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextView._setHint11874 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setHint", "(I)V");
			global::android.widget.TextView._getHint11875 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getHint", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setInputType11876 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setInputType", "(I)V");
			global::android.widget.TextView._setRawInputType11877 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setRawInputType", "(I)V");
			global::android.widget.TextView._getInputType11878 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getInputType", "()I");
			global::android.widget.TextView._setImeOptions11879 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setImeOptions", "(I)V");
			global::android.widget.TextView._getImeOptions11880 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeOptions", "()I");
			global::android.widget.TextView._setImeActionLabel11881 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setImeActionLabel", "(Ljava/lang/CharSequence;I)V");
			global::android.widget.TextView._getImeActionLabel11882 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeActionLabel", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._getImeActionId11883 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getImeActionId", "()I");
			global::android.widget.TextView._setOnEditorActionListener11884 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V");
			global::android.widget.TextView._onEditorAction11885 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onEditorAction", "(I)V");
			global::android.widget.TextView._setPrivateImeOptions11886 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setPrivateImeOptions", "(Ljava/lang/String;)V");
			global::android.widget.TextView._getPrivateImeOptions11887 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getPrivateImeOptions", "()Ljava/lang/String;");
			global::android.widget.TextView._setInputExtras11888 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setInputExtras", "(I)V");
			global::android.widget.TextView._getInputExtras11889 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getInputExtras", "(Z)Landroid/os/Bundle;");
			global::android.widget.TextView._getError11890 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getError", "()Ljava/lang/CharSequence;");
			global::android.widget.TextView._setFrame11891 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.TextView._setFilters11892 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setFilters", "([Landroid/text/InputFilter;)V");
			global::android.widget.TextView._getFilters11893 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getFilters", "()[Landroid/text/InputFilter;");
			global::android.widget.TextView._onPreDraw11894 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onPreDraw", "()Z");
			global::android.widget.TextView._getLineCount11895 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineCount", "()I");
			global::android.widget.TextView._getLineBounds11896 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.widget.TextView._extractText11897 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/ExtractedText;)Z");
			global::android.widget.TextView._setExtractedText11898 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V");
			global::android.widget.TextView._onCommitCompletion11899 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V");
			global::android.widget.TextView._beginBatchEdit11900 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "beginBatchEdit", "()V");
			global::android.widget.TextView._endBatchEdit11901 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "endBatchEdit", "()V");
			global::android.widget.TextView._onBeginBatchEdit11902 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onBeginBatchEdit", "()V");
			global::android.widget.TextView._onEndBatchEdit11903 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onEndBatchEdit", "()V");
			global::android.widget.TextView._onPrivateIMECommand11904 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z");
			global::android.widget.TextView._setIncludeFontPadding11905 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setIncludeFontPadding", "(Z)V");
			global::android.widget.TextView._bringPointIntoView11906 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "bringPointIntoView", "(I)Z");
			global::android.widget.TextView._moveCursorToVisibleOffset11907 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "moveCursorToVisibleOffset", "()Z");
			global::android.widget.TextView._getSelectionStart11908 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getSelectionStart", "()I");
			global::android.widget.TextView._getSelectionEnd11909 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getSelectionEnd", "()I");
			global::android.widget.TextView._hasSelection11910 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "hasSelection", "()Z");
			global::android.widget.TextView._setSingleLine11911 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSingleLine", "()V");
			global::android.widget.TextView._setSingleLine11912 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSingleLine", "(Z)V");
			global::android.widget.TextView._setEllipsize11913 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V");
			global::android.widget.TextView._setMarqueeRepeatLimit11914 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setMarqueeRepeatLimit", "(I)V");
			global::android.widget.TextView._getEllipsize11915 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "getEllipsize", "()Landroid/text/TextUtils$TruncateAt;");
			global::android.widget.TextView._setSelectAllOnFocus11916 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setSelectAllOnFocus", "(Z)V");
			global::android.widget.TextView._setCursorVisible11917 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setCursorVisible", "(Z)V");
			global::android.widget.TextView._onTextChanged11918 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			global::android.widget.TextView._onSelectionChanged11919 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onSelectionChanged", "(II)V");
			global::android.widget.TextView._addTextChangedListener11920 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "addTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._removeTextChangedListener11921 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "removeTextChangedListener", "(Landroid/text/TextWatcher;)V");
			global::android.widget.TextView._clearComposingText11922 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "clearComposingText", "()V");
			global::android.widget.TextView._didTouchFocusSelect11923 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "didTouchFocusSelect", "()Z");
			global::android.widget.TextView._setScroller11924 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "setScroller", "(Landroid/widget/Scroller;)V");
			global::android.widget.TextView._getTextColor11925 = @__env.GetStaticMethodID(global::android.widget.TextView.staticClass, "getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I");
			global::android.widget.TextView._isInputMethodTarget11926 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "isInputMethodTarget", "()Z");
			global::android.widget.TextView._onTextContextMenuItem11927 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "onTextContextMenuItem", "(I)Z");
			global::android.widget.TextView._TextView11928 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TextView._TextView11929 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TextView._TextView11930 = @__env.GetMethodID(global::android.widget.TextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
