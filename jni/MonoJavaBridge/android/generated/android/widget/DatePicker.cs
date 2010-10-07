namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DatePicker : android.widget.FrameLayout
	{
		internal new static global::java.lang.Class staticClass;
		static DatePicker()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.DatePicker), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.DatePicker(@__env);
			}
		}
		protected DatePicker(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnDateChangedListener 
		{
			void onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3);
		}

		public partial class OnDateChangedListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnDateChangedListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnDateChangedListener : java.lang.Object, OnDateChangedListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnDateChangedListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.DatePicker.__OnDateChangedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.DatePicker.__OnDateChangedListener(@__env);
				}
			}
			internal __OnDateChangedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDateChanged10786;
			 void android.widget.DatePicker.OnDateChangedListener.onDateChanged(android.widget.DatePicker arg0, int arg1, int arg2, int arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.DatePicker.__OnDateChangedListener._onDateChanged10786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.DatePicker.__OnDateChangedListener.staticClass, global::android.widget.DatePicker.__OnDateChangedListener._onDateChanged10786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.DatePicker.__OnDateChangedListener.staticClass = @__class;
				global::android.widget.DatePicker.__OnDateChangedListener._onDateChanged10786 = @__env.GetMethodID(global::android.widget.DatePicker.__OnDateChangedListener.staticClass, "android.widget.DatePicker.OnDateChangedListener.onDateChanged", "(Landroid/widget/DatePicker;III)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _init10787;
		public virtual void init(int arg0, int arg1, int arg2, android.widget.DatePicker.OnDateChangedListener arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DatePicker._init10787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._init10787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYear10788;
		public virtual int getYear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.DatePicker._getYear10788);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getYear10788);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMonth10789;
		public virtual int getMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.DatePicker._getMonth10789);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getMonth10789);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDayOfMonth10790;
		public virtual int getDayOfMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.DatePicker._getDayOfMonth10790);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._getDayOfMonth10790);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEnabled10791;
		public override void setEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DatePicker._setEnabled10791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._setEnabled10791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState10792;
		protected override void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DatePicker._onRestoreInstanceState10792, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._onRestoreInstanceState10792, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState10793;
		protected override global::android.os.Parcelable onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.DatePicker._onSaveInstanceState10793));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._onSaveInstanceState10793));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState10794;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DatePicker._dispatchRestoreInstanceState10794, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._dispatchRestoreInstanceState10794, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDate10795;
		public virtual void updateDate(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.DatePicker._updateDate10795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.DatePicker.staticClass, global::android.widget.DatePicker._updateDate10795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DatePicker10796;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker10796, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DatePicker10797;
		public DatePicker(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker10797, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DatePicker10798;
		public DatePicker(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.DatePicker.staticClass, global::android.widget.DatePicker._DatePicker10798, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.DatePicker.staticClass = @__class;
			global::android.widget.DatePicker._init10787 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V");
			global::android.widget.DatePicker._getYear10788 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "getYear", "()I");
			global::android.widget.DatePicker._getMonth10789 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "getMonth", "()I");
			global::android.widget.DatePicker._getDayOfMonth10790 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "getDayOfMonth", "()I");
			global::android.widget.DatePicker._setEnabled10791 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "setEnabled", "(Z)V");
			global::android.widget.DatePicker._onRestoreInstanceState10792 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.DatePicker._onSaveInstanceState10793 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.DatePicker._dispatchRestoreInstanceState10794 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.widget.DatePicker._updateDate10795 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "updateDate", "(III)V");
			global::android.widget.DatePicker._DatePicker10796 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.DatePicker._DatePicker10797 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.DatePicker._DatePicker10798 = @__env.GetMethodID(global::android.widget.DatePicker.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
