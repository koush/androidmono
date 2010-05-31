namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SurfaceHolder 
	{ 
		void setType(int arg0); 
		void setFormat(int arg0); 
		void setKeepScreenOn(bool arg0); 
		void addCallback(android.view.SurfaceHolder_Callback arg0); 
		void removeCallback(android.view.SurfaceHolder_Callback arg0); 
		bool isCreating(); 
		void setFixedSize(int arg0, int arg1); 
		void setSizeFromLayout(); 
		global::android.graphics.Canvas lockCanvas(); 
		global::android.graphics.Canvas lockCanvas(android.graphics.Rect arg0); 
		void unlockCanvasAndPost(android.graphics.Canvas arg0); 
		global::android.graphics.Rect getSurfaceFrame(); 
		global::android.view.Surface getSurface(); 
	} 

	public partial class SurfaceHolder_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SurfaceHolder.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SurfaceHolder : java.lang.Object, SurfaceHolder
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SurfaceHolder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__SurfaceHolder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.__SurfaceHolder(@__env); 
			} 
		} 
		internal __SurfaceHolder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setType8057; 
		 void android.view.SurfaceHolder.setType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._setType8057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._setType8057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFormat8058; 
		 void android.view.SurfaceHolder.setFormat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._setFormat8058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._setFormat8058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeepScreenOn8059; 
		 void android.view.SurfaceHolder.setKeepScreenOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._setKeepScreenOn8059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._setKeepScreenOn8059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addCallback8060; 
		 void android.view.SurfaceHolder.addCallback(android.view.SurfaceHolder_Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._addCallback8060, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._addCallback8060, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeCallback8061; 
		 void android.view.SurfaceHolder.removeCallback(android.view.SurfaceHolder_Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._removeCallback8061, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._removeCallback8061, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCreating8062; 
		 bool android.view.SurfaceHolder.isCreating() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.__SurfaceHolder._isCreating8062); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._isCreating8062); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFixedSize8063; 
		 void android.view.SurfaceHolder.setFixedSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._setFixedSize8063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._setFixedSize8063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSizeFromLayout8064; 
		 void android.view.SurfaceHolder.setSizeFromLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._setSizeFromLayout8064); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._setSizeFromLayout8064); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lockCanvas8065; 
		 global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SurfaceHolder._lockCanvas8065)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._lockCanvas8065)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lockCanvas8066; 
		 global::android.graphics.Canvas android.view.SurfaceHolder.lockCanvas(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SurfaceHolder._lockCanvas8066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._lockCanvas8066, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unlockCanvasAndPost8067; 
		 void android.view.SurfaceHolder.unlockCanvasAndPost(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder._unlockCanvasAndPost8067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._unlockCanvasAndPost8067, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSurfaceFrame8068; 
		 global::android.graphics.Rect android.view.SurfaceHolder.getSurfaceFrame() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SurfaceHolder._getSurfaceFrame8068)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._getSurfaceFrame8068)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSurface8069; 
		 global::android.view.Surface android.view.SurfaceHolder.getSurface() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Surface>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__SurfaceHolder._getSurface8069)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Surface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__SurfaceHolder.staticClass, global::android.view.__SurfaceHolder._getSurface8069)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.__SurfaceHolder.staticClass = @__class; 
			global::android.view.__SurfaceHolder._setType8057 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.setType", "(I)V"); 
			global::android.view.__SurfaceHolder._setFormat8058 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.setFormat", "(I)V"); 
			global::android.view.__SurfaceHolder._setKeepScreenOn8059 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.setKeepScreenOn", "(Z)V"); 
			global::android.view.__SurfaceHolder._addCallback8060 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.addCallback", "(Landroid/view/SurfaceHolder$Callback;)V"); 
			global::android.view.__SurfaceHolder._removeCallback8061 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V"); 
			global::android.view.__SurfaceHolder._isCreating8062 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.isCreating", "()Z"); 
			global::android.view.__SurfaceHolder._setFixedSize8063 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.setFixedSize", "(II)V"); 
			global::android.view.__SurfaceHolder._setSizeFromLayout8064 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.setSizeFromLayout", "()V"); 
			global::android.view.__SurfaceHolder._lockCanvas8065 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.lockCanvas", "()Landroid/graphics/Canvas;"); 
			global::android.view.__SurfaceHolder._lockCanvas8066 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;"); 
			global::android.view.__SurfaceHolder._unlockCanvasAndPost8067 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.__SurfaceHolder._getSurfaceFrame8068 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.getSurfaceFrame", "()Landroid/graphics/Rect;"); 
			global::android.view.__SurfaceHolder._getSurface8069 = @__env.GetMethodID(global::android.view.__SurfaceHolder.staticClass, "android.view.SurfaceHolder.getSurface", "()Landroid/view/Surface;"); 
		} 
	} 
} 
