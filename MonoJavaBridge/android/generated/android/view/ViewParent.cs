namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewParent_))]
	public partial interface ViewParent  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.view.ViewParent getParent();
		global::android.view.View focusSearch(android.view.View arg0, int arg1);
		void createContextMenu(android.view.ContextMenu arg0);
		bool isLayoutRequested();
		void requestLayout();
		void requestChildFocus(android.view.View arg0, android.view.View arg1);
		void focusableViewAvailable(android.view.View arg0);
		bool showContextMenuForChild(android.view.View arg0);
		bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2);
		void clearChildFocus(android.view.View arg0);
		void recomputeViewAttributes(android.view.View arg0);
		void bringChildToFront(android.view.View arg0);
		void requestDisallowInterceptTouchEvent(bool arg0);
		void invalidateChild(android.view.View arg0, android.graphics.Rect arg1);
		global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1);
		bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2);
		void requestTransparentRegion(android.view.View arg0);
		void childDrawableStateChanged(android.view.View arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewParent))]
	internal sealed partial class ViewParent_ : java.lang.Object, ViewParent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ViewParent_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent15188;
		global::android.view.ViewParent android.view.ViewParent.getParent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._getParent15188.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._getParent15188 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "getParent", "()Landroid/view/ViewParent;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._getParent15188)) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch15189;
		global::android.view.View android.view.ViewParent.focusSearch(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._focusSearch15189.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._focusSearch15189 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._focusSearch15189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _createContextMenu15190;
		void android.view.ViewParent.createContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._createContextMenu15190.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._createContextMenu15190 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._createContextMenu15190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLayoutRequested15191;
		bool android.view.ViewParent.isLayoutRequested()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._isLayoutRequested15191.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._isLayoutRequested15191 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "isLayoutRequested", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._isLayoutRequested15191);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout15192;
		void android.view.ViewParent.requestLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._requestLayout15192.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._requestLayout15192 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestLayout", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestLayout15192);
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus15193;
		void android.view.ViewParent.requestChildFocus(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._requestChildFocus15193.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._requestChildFocus15193 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestChildFocus15193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _focusableViewAvailable15194;
		void android.view.ViewParent.focusableViewAvailable(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._focusableViewAvailable15194.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._focusableViewAvailable15194 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._focusableViewAvailable15194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild15195;
		bool android.view.ViewParent.showContextMenuForChild(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._showContextMenuForChild15195.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._showContextMenuForChild15195 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._showContextMenuForChild15195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen15196;
		bool android.view.ViewParent.requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._requestChildRectangleOnScreen15196.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._requestChildRectangleOnScreen15196 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._requestChildRectangleOnScreen15196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearChildFocus15197;
		void android.view.ViewParent.clearChildFocus(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._clearChildFocus15197.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._clearChildFocus15197 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._clearChildFocus15197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _recomputeViewAttributes15198;
		void android.view.ViewParent.recomputeViewAttributes(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._recomputeViewAttributes15198.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._recomputeViewAttributes15198 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._recomputeViewAttributes15198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringChildToFront15199;
		void android.view.ViewParent.bringChildToFront(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._bringChildToFront15199.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._bringChildToFront15199 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._bringChildToFront15199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestDisallowInterceptTouchEvent15200;
		void android.view.ViewParent.requestDisallowInterceptTouchEvent(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._requestDisallowInterceptTouchEvent15200.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._requestDisallowInterceptTouchEvent15200 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestDisallowInterceptTouchEvent15200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChild15201;
		void android.view.ViewParent.invalidateChild(android.view.View arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._invalidateChild15201.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._invalidateChild15201 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._invalidateChild15201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChildInParent15202;
		global::android.view.ViewParent android.view.ViewParent.invalidateChildInParent(int[] arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._invalidateChildInParent15202.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._invalidateChildInParent15202 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._invalidateChildInParent15202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _getChildVisibleRect15203;
		bool android.view.ViewParent.getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._getChildVisibleRect15203.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._getChildVisibleRect15203 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._getChildVisibleRect15203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _requestTransparentRegion15204;
		void android.view.ViewParent.requestTransparentRegion(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._requestTransparentRegion15204.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._requestTransparentRegion15204 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestTransparentRegion15204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged15205;
		void android.view.ViewParent.childDrawableStateChanged(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewParent_._childDrawableStateChanged15205.native == global::System.IntPtr.Zero)
				global::android.view.ViewParent_._childDrawableStateChanged15205 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._childDrawableStateChanged15205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ViewParent_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewParent_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewParent"));
		}
		internal static void InitJNI()
		{
		}
	}
}
