namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ImageSwitcher : android.widget.ViewSwitcher
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ImageSwitcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ImageSwitcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ImageSwitcher(@__env); 
			} 
		} 
		protected ImageSwitcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageResource9607; 
		public virtual void setImageResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageSwitcher)) 
				@__env.CallVoidMethod(this, _setImageResource9607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageSwitcher.staticClass, _setImageResource9607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageURI9608; 
		public virtual void setImageURI(android.net.Uri arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageSwitcher)) 
				@__env.CallVoidMethod(this, _setImageURI9608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageSwitcher.staticClass, _setImageURI9608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setImageDrawable9609; 
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ImageSwitcher)) 
				@__env.CallVoidMethod(this, _setImageDrawable9609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ImageSwitcher.staticClass, _setImageDrawable9609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSwitcher9610; 
		public ImageSwitcher(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ImageSwitcher.staticClass, _ImageSwitcher9610, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ImageSwitcher9611; 
		public ImageSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ImageSwitcher.staticClass, _ImageSwitcher9611, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ImageSwitcher.staticClass = @__class; 
			global::android.widget.ImageSwitcher._setImageResource9607 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "setImageResource", "(I)V"); 
			global::android.widget.ImageSwitcher._setImageURI9608 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "setImageURI", "(Landroid/net/Uri;)V"); 
			global::android.widget.ImageSwitcher._setImageDrawable9609 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.widget.ImageSwitcher._ImageSwitcher9610 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ImageSwitcher._ImageSwitcher9611 = @__env.GetMethodID(global::android.widget.ImageSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
