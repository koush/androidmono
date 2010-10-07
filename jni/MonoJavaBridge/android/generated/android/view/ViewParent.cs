namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ViewParent 
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

	public partial class ViewParent_
	{
		public static global::java.lang.Class _class
		{
			get { return __ViewParent.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ViewParent : java.lang.Object, ViewParent
	{
		internal static global::java.lang.Class staticClass;
		static __ViewParent()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__ViewParent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.__ViewParent(@__env);
			}
		}
		internal __ViewParent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParent9318;
		 global::android.view.ViewParent android.view.ViewParent.getParent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ViewParent._getParent9318));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._getParent9318));
		}
		internal static global::net.sf.jni4net.jni.MethodId _focusSearch9319;
		 global::android.view.View android.view.ViewParent.focusSearch(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ViewParent._focusSearch9319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._focusSearch9319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createContextMenu9320;
		 void android.view.ViewParent.createContextMenu(android.view.ContextMenu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._createContextMenu9320, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._createContextMenu9320, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLayoutRequested9321;
		 bool android.view.ViewParent.isLayoutRequested() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ViewParent._isLayoutRequested9321);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._isLayoutRequested9321);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9322;
		 void android.view.ViewParent.requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._requestLayout9322);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._requestLayout9322);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus9323;
		 void android.view.ViewParent.requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._requestChildFocus9323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._requestChildFocus9323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _focusableViewAvailable9324;
		 void android.view.ViewParent.focusableViewAvailable(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._focusableViewAvailable9324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._focusableViewAvailable9324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild9325;
		 bool android.view.ViewParent.showContextMenuForChild(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ViewParent._showContextMenuForChild9325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._showContextMenuForChild9325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen9326;
		 bool android.view.ViewParent.requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ViewParent._requestChildRectangleOnScreen9326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._requestChildRectangleOnScreen9326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearChildFocus9327;
		 void android.view.ViewParent.clearChildFocus(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._clearChildFocus9327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._clearChildFocus9327, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recomputeViewAttributes9328;
		 void android.view.ViewParent.recomputeViewAttributes(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._recomputeViewAttributes9328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._recomputeViewAttributes9328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bringChildToFront9329;
		 void android.view.ViewParent.bringChildToFront(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._bringChildToFront9329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._bringChildToFront9329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestDisallowInterceptTouchEvent9330;
		 void android.view.ViewParent.requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._requestDisallowInterceptTouchEvent9330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._requestDisallowInterceptTouchEvent9330, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChild9331;
		 void android.view.ViewParent.invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._invalidateChild9331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._invalidateChild9331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChildInParent9332;
		 global::android.view.ViewParent android.view.ViewParent.invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__ViewParent._invalidateChildInParent9332, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._invalidateChildInParent9332, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildVisibleRect9333;
		 bool android.view.ViewParent.getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.__ViewParent._getChildVisibleRect9333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._getChildVisibleRect9333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestTransparentRegion9334;
		 void android.view.ViewParent.requestTransparentRegion(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._requestTransparentRegion9334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._requestTransparentRegion9334, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _childDrawableStateChanged9335;
		 void android.view.ViewParent.childDrawableStateChanged(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__ViewParent._childDrawableStateChanged9335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewParent.staticClass, global::android.view.__ViewParent._childDrawableStateChanged9335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.__ViewParent.staticClass = @__class;
			global::android.view.__ViewParent._getParent9318 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.getParent", "()Landroid/view/ViewParent;");
			global::android.view.__ViewParent._focusSearch9319 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.__ViewParent._createContextMenu9320 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.createContextMenu", "(Landroid/view/ContextMenu;)V");
			global::android.view.__ViewParent._isLayoutRequested9321 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.isLayoutRequested", "()Z");
			global::android.view.__ViewParent._requestLayout9322 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.requestLayout", "()V");
			global::android.view.__ViewParent._requestChildFocus9323 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.__ViewParent._focusableViewAvailable9324 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.__ViewParent._showContextMenuForChild9325 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.__ViewParent._requestChildRectangleOnScreen9326 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.__ViewParent._clearChildFocus9327 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.__ViewParent._recomputeViewAttributes9328 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.__ViewParent._bringChildToFront9329 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.__ViewParent._requestDisallowInterceptTouchEvent9330 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.__ViewParent._invalidateChild9331 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.__ViewParent._invalidateChildInParent9332 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.__ViewParent._getChildVisibleRect9333 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.__ViewParent._requestTransparentRegion9334 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.__ViewParent._childDrawableStateChanged9335 = @__env.GetMethodID(global::android.view.__ViewParent.staticClass, "android.view.ViewParent.childDrawableStateChanged", "(Landroid/view/View;)V");
		}
	}
}
