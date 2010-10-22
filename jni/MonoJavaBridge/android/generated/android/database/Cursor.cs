namespace android.database
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.Cursor_))]
	public interface Cursor  : global::MonoJavaBridge.IJavaObject 
	{
		short getShort(int arg0);
		int getInt(int arg0);
		long getLong(int arg0);
		float getFloat(int arg0);
		double getDouble(int arg0);
		void close();
		global::java.lang.String getString(int arg0);
		bool isFirst();
		bool isClosed();
		int getPosition();
		global::android.os.Bundle getExtras();
		void registerContentObserver(android.database.ContentObserver arg0);
		void unregisterContentObserver(android.database.ContentObserver arg0);
		int getCount();
		bool move(int arg0);
		bool moveToPosition(int arg0);
		bool moveToFirst();
		bool moveToLast();
		bool moveToNext();
		bool moveToPrevious();
		bool isLast();
		bool isBeforeFirst();
		bool isAfterLast();
		int getColumnIndex(java.lang.String arg0);
		int getColumnIndexOrThrow(java.lang.String arg0);
		global::java.lang.String getColumnName(int arg0);
		global::java.lang.String[] getColumnNames();
		int getColumnCount();
		byte[] getBlob(int arg0);
		void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1);
		bool isNull(int arg0);
		void deactivate();
		bool requery();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1);
		bool getWantsAllOnMoveCalls();
		global::android.os.Bundle respond(android.os.Bundle arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.Cursor))]
	public sealed partial class Cursor_ : java.lang.Object, Cursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Cursor_()
		{
			InitJNI();
		}
		internal Cursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4459;
		 short android.database.Cursor.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.Cursor_._getShort4459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getShort4459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4460;
		 int android.database.Cursor.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getInt4460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getInt4460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4461;
		 long android.database.Cursor.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.Cursor_._getLong4461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getLong4461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4462;
		 float android.database.Cursor.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.Cursor_._getFloat4462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getFloat4462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4463;
		 double android.database.Cursor.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.Cursor_._getDouble4463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getDouble4463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4464;
		 void android.database.Cursor.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._close4464);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._close4464);
		}
		internal static global::MonoJavaBridge.MethodId _getString4465;
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getString4465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getString4465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst4466;
		 bool android.database.Cursor.isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isFirst4466);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isFirst4466);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4467;
		 bool android.database.Cursor.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isClosed4467);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isClosed4467);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4468;
		 int android.database.Cursor.getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getPosition4468);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getPosition4468);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4469;
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getExtras4469)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getExtras4469)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4470;
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._registerContentObserver4470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._registerContentObserver4470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4471;
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._unregisterContentObserver4471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._unregisterContentObserver4471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount4472;
		 int android.database.Cursor.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getCount4472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getCount4472);
		}
		internal static global::MonoJavaBridge.MethodId _move4473;
		 bool android.database.Cursor.move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._move4473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._move4473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4474;
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToPosition4474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToPosition4474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4475;
		 bool android.database.Cursor.moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToFirst4475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToFirst4475);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4476;
		 bool android.database.Cursor.moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToLast4476);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToLast4476);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4477;
		 bool android.database.Cursor.moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToNext4477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToNext4477);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4478;
		 bool android.database.Cursor.moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToPrevious4478);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToPrevious4478);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4479;
		 bool android.database.Cursor.isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isLast4479);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isLast4479);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4480;
		 bool android.database.Cursor.isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isBeforeFirst4480);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isBeforeFirst4480);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4481;
		 bool android.database.Cursor.isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isAfterLast4481);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isAfterLast4481);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4482;
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnIndex4482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnIndex4482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4483;
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnIndexOrThrow4483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnIndexOrThrow4483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4484;
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getColumnName4484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnName4484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4485;
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getColumnNames4485)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnNames4485)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount4486;
		 int android.database.Cursor.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnCount4486);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnCount4486);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4487;
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getBlob4487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getBlob4487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4488;
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._copyStringToBuffer4488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._copyStringToBuffer4488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4489;
		 bool android.database.Cursor.isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isNull4489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isNull4489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4490;
		 void android.database.Cursor.deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._deactivate4490);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._deactivate4490);
		}
		internal static global::MonoJavaBridge.MethodId _requery4491;
		 bool android.database.Cursor.requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._requery4491);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._requery4491);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4492;
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._registerDataSetObserver4492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._registerDataSetObserver4492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4493;
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._unregisterDataSetObserver4493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._unregisterDataSetObserver4493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4494;
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._setNotificationUri4494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._setNotificationUri4494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4495;
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._getWantsAllOnMoveCalls4495);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getWantsAllOnMoveCalls4495);
		}
		internal static global::MonoJavaBridge.MethodId _respond4496;
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._respond4496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._respond4496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Cursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Cursor"));
			global::android.database.Cursor_._getShort4459 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getShort", "(I)S");
			global::android.database.Cursor_._getInt4460 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getInt", "(I)I");
			global::android.database.Cursor_._getLong4461 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getLong", "(I)J");
			global::android.database.Cursor_._getFloat4462 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getFloat", "(I)F");
			global::android.database.Cursor_._getDouble4463 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getDouble", "(I)D");
			global::android.database.Cursor_._close4464 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "close", "()V");
			global::android.database.Cursor_._getString4465 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.Cursor_._isFirst4466 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isFirst", "()Z");
			global::android.database.Cursor_._isClosed4467 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isClosed", "()Z");
			global::android.database.Cursor_._getPosition4468 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getPosition", "()I");
			global::android.database.Cursor_._getExtras4469 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.Cursor_._registerContentObserver4470 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.Cursor_._unregisterContentObserver4471 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.Cursor_._getCount4472 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getCount", "()I");
			global::android.database.Cursor_._move4473 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "move", "(I)Z");
			global::android.database.Cursor_._moveToPosition4474 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToPosition", "(I)Z");
			global::android.database.Cursor_._moveToFirst4475 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToFirst", "()Z");
			global::android.database.Cursor_._moveToLast4476 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToLast", "()Z");
			global::android.database.Cursor_._moveToNext4477 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToNext", "()Z");
			global::android.database.Cursor_._moveToPrevious4478 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToPrevious", "()Z");
			global::android.database.Cursor_._isLast4479 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isLast", "()Z");
			global::android.database.Cursor_._isBeforeFirst4480 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isBeforeFirst", "()Z");
			global::android.database.Cursor_._isAfterLast4481 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isAfterLast", "()Z");
			global::android.database.Cursor_._getColumnIndex4482 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.Cursor_._getColumnIndexOrThrow4483 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.Cursor_._getColumnName4484 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.Cursor_._getColumnNames4485 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.Cursor_._getColumnCount4486 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnCount", "()I");
			global::android.database.Cursor_._getBlob4487 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getBlob", "(I)[B");
			global::android.database.Cursor_._copyStringToBuffer4488 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.Cursor_._isNull4489 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isNull", "(I)Z");
			global::android.database.Cursor_._deactivate4490 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "deactivate", "()V");
			global::android.database.Cursor_._requery4491 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "requery", "()Z");
			global::android.database.Cursor_._registerDataSetObserver4492 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.Cursor_._unregisterDataSetObserver4493 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.Cursor_._setNotificationUri4494 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.Cursor_._getWantsAllOnMoveCalls4495 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.Cursor_._respond4496 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
		}
	}
}
