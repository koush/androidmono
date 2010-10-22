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
	public sealed partial class ViewParent_ : java.lang.Object, ViewParent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewParent_()
		{
			InitJNI();
		}
		internal ViewParent_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParent15114;
		 global::android.view.ViewParent android.view.ViewParent.getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._getParent15114)) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._getParent15114)) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch15115;
		 global::android.view.View android.view.ViewParent.focusSearch(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._focusSearch15115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._focusSearch15115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _createContextMenu15116;
		 void android.view.ViewParent.createContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._createContextMenu15116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._createContextMenu15116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLayoutRequested15117;
		 bool android.view.ViewParent.isLayoutRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._isLayoutRequested15117);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._isLayoutRequested15117);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout15118;
		 void android.view.ViewParent.requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestLayout15118);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestLayout15118);
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus15119;
		 void android.view.ViewParent.requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestChildFocus15119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestChildFocus15119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _focusableViewAvailable15120;
		 void android.view.ViewParent.focusableViewAvailable(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._focusableViewAvailable15120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._focusableViewAvailable15120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild15121;
		 bool android.view.ViewParent.showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._showContextMenuForChild15121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._showContextMenuForChild15121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen15122;
		 bool android.view.ViewParent.requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._requestChildRectangleOnScreen15122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestChildRectangleOnScreen15122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearChildFocus15123;
		 void android.view.ViewParent.clearChildFocus(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._clearChildFocus15123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._clearChildFocus15123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _recomputeViewAttributes15124;
		 void android.view.ViewParent.recomputeViewAttributes(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._recomputeViewAttributes15124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._recomputeViewAttributes15124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringChildToFront15125;
		 void android.view.ViewParent.bringChildToFront(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._bringChildToFront15125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._bringChildToFront15125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestDisallowInterceptTouchEvent15126;
		 void android.view.ViewParent.requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestDisallowInterceptTouchEvent15126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestDisallowInterceptTouchEvent15126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChild15127;
		 void android.view.ViewParent.invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._invalidateChild15127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._invalidateChild15127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChildInParent15128;
		 global::android.view.ViewParent android.view.ViewParent.invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._invalidateChildInParent15128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._invalidateChildInParent15128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _getChildVisibleRect15129;
		 bool android.view.ViewParent.getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._getChildVisibleRect15129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._getChildVisibleRect15129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _requestTransparentRegion15130;
		 void android.view.ViewParent.requestTransparentRegion(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestTransparentRegion15130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestTransparentRegion15130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged15131;
		 void android.view.ViewParent.childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._childDrawableStateChanged15131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._childDrawableStateChanged15131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewParent_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewParent"));
			global::android.view.ViewParent_._getParent15114 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "getParent", "()Landroid/view/ViewParent;");
			global::android.view.ViewParent_._focusSearch15115 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.ViewParent_._createContextMenu15116 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.ViewParent_._isLayoutRequested15117 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "isLayoutRequested", "()Z");
			global::android.view.ViewParent_._requestLayout15118 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestLayout", "()V");
			global::android.view.ViewParent_._requestChildFocus15119 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.ViewParent_._focusableViewAvailable15120 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._showContextMenuForChild15121 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.ViewParent_._requestChildRectangleOnScreen15122 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.ViewParent_._clearChildFocus15123 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._recomputeViewAttributes15124 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._bringChildToFront15125 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._requestDisallowInterceptTouchEvent15126 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.ViewParent_._invalidateChild15127 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewParent_._invalidateChildInParent15128 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.ViewParent_._getChildVisibleRect15129 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.ViewParent_._requestTransparentRegion15130 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._childDrawableStateChanged15131 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
		}
	}
}
