namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SeekBar : android.widget.AbsSeekBar
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SeekBar() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.SeekBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.SeekBar(@__env); 
			} 
		} 
		protected SeekBar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnSeekBarChangeListener 
		{ 
			void onProgressChanged(android.widget.SeekBar arg0, int arg1, bool arg2); 
			void onStartTrackingTouch(android.widget.SeekBar arg0); 
			void onStopTrackingTouch(android.widget.SeekBar arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnSeekBarChangeListener10020; 
		public virtual void setOnSeekBarChangeListener(android.widget.SeekBar.OnSeekBarChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.SeekBar)) 
				@__env.CallVoidMethod(this, _setOnSeekBarChangeListener10020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.SeekBar.staticClass, _setOnSeekBarChangeListener10020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SeekBar10021; 
		public SeekBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SeekBar.staticClass, _SeekBar10021, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SeekBar10022; 
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SeekBar.staticClass, _SeekBar10022, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SeekBar10023; 
		public SeekBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.SeekBar.staticClass, _SeekBar10023, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.SeekBar.staticClass = @__class; 
			global::android.widget.SeekBar._setOnSeekBarChangeListener10020 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V"); 
			global::android.widget.SeekBar._SeekBar10021 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.SeekBar._SeekBar10022 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.SeekBar._SeekBar10023 = @__env.GetMethodID(global::android.widget.SeekBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
