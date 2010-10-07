namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class CompoundButton : android.widget.Button, Checkable
	{
		internal new static global::java.lang.Class staticClass;
		static CompoundButton()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.CompoundButton), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected CompoundButton(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnCheckedChangeListener 
		{
			void onCheckedChanged(android.widget.CompoundButton arg0, bool arg1);
		}

		public partial class OnCheckedChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnCheckedChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnCheckedChangeListener : java.lang.Object, OnCheckedChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnCheckedChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.CompoundButton.__OnCheckedChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.CompoundButton.__OnCheckedChangeListener(@__env);
				}
			}
			internal __OnCheckedChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCheckedChanged10718;
			 void android.widget.CompoundButton.OnCheckedChangeListener.onCheckedChanged(android.widget.CompoundButton arg0, bool arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.CompoundButton.__OnCheckedChangeListener._onCheckedChanged10718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.__OnCheckedChangeListener.staticClass, global::android.widget.CompoundButton.__OnCheckedChangeListener._onCheckedChanged10718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.CompoundButton.__OnCheckedChangeListener.staticClass = @__class;
				global::android.widget.CompoundButton.__OnCheckedChangeListener._onCheckedChanged10718 = @__env.GetMethodID(global::android.widget.CompoundButton.__OnCheckedChangeListener.staticClass, "android.widget.CompoundButton.OnCheckedChangeListener.onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggle10719;
		public virtual void toggle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._toggle10719);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._toggle10719);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChecked10720;
		public virtual bool isChecked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.CompoundButton._isChecked10720);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._isChecked10720);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked10721;
		public virtual void setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._setChecked10721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setChecked10721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10722;
		public override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._onRestoreInstanceState10722, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onRestoreInstanceState10722, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10723;
		public override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CompoundButton._onSaveInstanceState10723));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onSaveInstanceState10723));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent10724;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent10724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent10724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performClick10725;
		public override bool performClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.CompoundButton._performClick10725);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._performClick10725);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw10726;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._onDraw10726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onDraw10726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable10727;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.CompoundButton._verifyDrawable10727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._verifyDrawable10727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged10728;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._drawableStateChanged10728);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._drawableStateChanged10728);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState10729;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CompoundButton._onCreateDrawableState10729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._onCreateDrawableState10729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCheckedChangeListener10730;
		public virtual void setOnCheckedChangeListener(android.widget.CompoundButton.OnCheckedChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._setOnCheckedChangeListener10730, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setOnCheckedChangeListener10730, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButtonDrawable10731;
		public virtual void setButtonDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._setButtonDrawable10731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable10731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButtonDrawable10732;
		public virtual void setButtonDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CompoundButton._setButtonDrawable10732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._setButtonDrawable10732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CompoundButton10733;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton10733, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CompoundButton10734;
		public CompoundButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton10734, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CompoundButton10735;
		public CompoundButton(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CompoundButton.staticClass, global::android.widget.CompoundButton._CompoundButton10735, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.CompoundButton.staticClass = @__class;
			global::android.widget.CompoundButton._toggle10719 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "toggle", "()V");
			global::android.widget.CompoundButton._isChecked10720 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "isChecked", "()Z");
			global::android.widget.CompoundButton._setChecked10721 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setChecked", "(Z)V");
			global::android.widget.CompoundButton._onRestoreInstanceState10722 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.CompoundButton._onSaveInstanceState10723 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.CompoundButton._dispatchPopulateAccessibilityEvent10724 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.CompoundButton._performClick10725 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "performClick", "()Z");
			global::android.widget.CompoundButton._onDraw10726 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.CompoundButton._verifyDrawable10727 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.CompoundButton._drawableStateChanged10728 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "drawableStateChanged", "()V");
			global::android.widget.CompoundButton._onCreateDrawableState10729 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.CompoundButton._setOnCheckedChangeListener10730 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V");
			global::android.widget.CompoundButton._setButtonDrawable10731 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.CompoundButton._setButtonDrawable10732 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "setButtonDrawable", "(I)V");
			global::android.widget.CompoundButton._CompoundButton10733 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CompoundButton._CompoundButton10734 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.CompoundButton._CompoundButton10735 = @__env.GetMethodID(global::android.widget.CompoundButton.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
