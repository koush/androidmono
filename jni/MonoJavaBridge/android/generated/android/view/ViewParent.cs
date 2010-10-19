namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewParent_))]
	public interface ViewParent  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _getParent10174;
		 global::android.view.ViewParent android.view.ViewParent.getParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._getParent10174)) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._getParent10174)) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch10175;
		 global::android.view.View android.view.ViewParent.focusSearch(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._focusSearch10175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._focusSearch10175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _createContextMenu10176;
		 void android.view.ViewParent.createContextMenu(android.view.ContextMenu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._createContextMenu10176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._createContextMenu10176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLayoutRequested10177;
		 bool android.view.ViewParent.isLayoutRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._isLayoutRequested10177);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._isLayoutRequested10177);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout10178;
		 void android.view.ViewParent.requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestLayout10178);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestLayout10178);
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus10179;
		 void android.view.ViewParent.requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestChildFocus10179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestChildFocus10179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _focusableViewAvailable10180;
		 void android.view.ViewParent.focusableViewAvailable(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._focusableViewAvailable10180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._focusableViewAvailable10180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild10181;
		 bool android.view.ViewParent.showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._showContextMenuForChild10181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._showContextMenuForChild10181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen10182;
		 bool android.view.ViewParent.requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._requestChildRectangleOnScreen10182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestChildRectangleOnScreen10182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearChildFocus10183;
		 void android.view.ViewParent.clearChildFocus(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._clearChildFocus10183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._clearChildFocus10183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _recomputeViewAttributes10184;
		 void android.view.ViewParent.recomputeViewAttributes(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._recomputeViewAttributes10184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._recomputeViewAttributes10184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringChildToFront10185;
		 void android.view.ViewParent.bringChildToFront(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._bringChildToFront10185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._bringChildToFront10185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestDisallowInterceptTouchEvent10186;
		 void android.view.ViewParent.requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestDisallowInterceptTouchEvent10186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestDisallowInterceptTouchEvent10186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChild10187;
		 void android.view.ViewParent.invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._invalidateChild10187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._invalidateChild10187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChildInParent10188;
		 global::android.view.ViewParent android.view.ViewParent.invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewParent_._invalidateChildInParent10188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._invalidateChildInParent10188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _getChildVisibleRect10189;
		 bool android.view.ViewParent.getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewParent_._getChildVisibleRect10189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._getChildVisibleRect10189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _requestTransparentRegion10190;
		 void android.view.ViewParent.requestTransparentRegion(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._requestTransparentRegion10190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._requestTransparentRegion10190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged10191;
		 void android.view.ViewParent.childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewParent_._childDrawableStateChanged10191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewParent_.staticClass, global::android.view.ViewParent_._childDrawableStateChanged10191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewParent_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewParent"));
			global::android.view.ViewParent_._getParent10174 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "getParent", "()Landroid/view/ViewParent;");
			global::android.view.ViewParent_._focusSearch10175 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.ViewParent_._createContextMenu10176 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.ViewParent_._isLayoutRequested10177 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "isLayoutRequested", "()Z");
			global::android.view.ViewParent_._requestLayout10178 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestLayout", "()V");
			global::android.view.ViewParent_._requestChildFocus10179 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.ViewParent_._focusableViewAvailable10180 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._showContextMenuForChild10181 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.ViewParent_._requestChildRectangleOnScreen10182 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.ViewParent_._clearChildFocus10183 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._recomputeViewAttributes10184 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._bringChildToFront10185 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._requestDisallowInterceptTouchEvent10186 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.ViewParent_._invalidateChild10187 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewParent_._invalidateChildInParent10188 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.ViewParent_._getChildVisibleRect10189 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.ViewParent_._requestTransparentRegion10190 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.ViewParent_._childDrawableStateChanged10191 = @__env.GetMethodIDNoThrow(global::android.view.ViewParent_.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
		}
	}
}
