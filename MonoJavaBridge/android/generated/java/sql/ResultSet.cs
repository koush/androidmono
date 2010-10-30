namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.ResultSet_))]
	public partial interface ResultSet  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object getObject(java.lang.String arg0);
		global::java.lang.Object getObject(int arg0, java.util.Map arg1);
		global::java.lang.Object getObject(int arg0);
		global::java.lang.Object getObject(java.lang.String arg0, java.util.Map arg1);
		bool getBoolean(java.lang.String arg0);
		bool getBoolean(int arg0);
		byte getByte(java.lang.String arg0);
		byte getByte(int arg0);
		short getShort(int arg0);
		short getShort(java.lang.String arg0);
		int getInt(java.lang.String arg0);
		int getInt(int arg0);
		long getLong(java.lang.String arg0);
		long getLong(int arg0);
		float getFloat(java.lang.String arg0);
		float getFloat(int arg0);
		double getDouble(int arg0);
		double getDouble(java.lang.String arg0);
		byte[] getBytes(java.lang.String arg0);
		byte[] getBytes(int arg0);
		global::java.sql.Array getArray(java.lang.String arg0);
		global::java.sql.Array getArray(int arg0);
		bool next();
		global::java.net.URL getURL(java.lang.String arg0);
		global::java.net.URL getURL(int arg0);
		void close();
		int getType();
		bool previous();
		global::java.sql.Ref getRef(int arg0);
		global::java.sql.Ref getRef(java.lang.String arg0);
		global::java.lang.String getString(java.lang.String arg0);
		global::java.lang.String getString(int arg0);
		bool isFirst();
		global::java.sql.Time getTime(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(java.lang.String arg0);
		global::java.sql.Time getTime(int arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(int arg0);
		global::java.sql.Date getDate(java.lang.String arg0);
		global::java.sql.Date getDate(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(int arg0);
		global::java.sql.Date getDate(int arg0, java.util.Calendar arg1);
		bool isClosed();
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0);
		global::java.sql.Timestamp getTimestamp(int arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(int arg0);
		bool last();
		bool first();
		void updateBytes(java.lang.String arg0, byte[] arg1);
		void updateBytes(int arg0, byte[] arg1);
		bool isLast();
		bool isBeforeFirst();
		bool isAfterLast();
		global::java.sql.Blob getBlob(java.lang.String arg0);
		global::java.sql.Blob getBlob(int arg0);
		void updateDate(int arg0, java.sql.Date arg1);
		void updateDate(java.lang.String arg0, java.sql.Date arg1);
		void updateTime(int arg0, java.sql.Time arg1);
		void updateTime(java.lang.String arg0, java.sql.Time arg1);
		void deleteRow();
		void updateBlob(java.lang.String arg0, java.sql.Blob arg1);
		void updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateBlob(int arg0, java.io.InputStream arg1);
		void updateBlob(int arg0, java.io.InputStream arg1, long arg2);
		void updateBlob(java.lang.String arg0, java.io.InputStream arg1);
		void updateBlob(int arg0, java.sql.Blob arg1);
		void updateDouble(int arg0, double arg1);
		void updateDouble(java.lang.String arg0, double arg1);
		void updateFloat(java.lang.String arg0, float arg1);
		void updateFloat(int arg0, float arg1);
		void updateInt(java.lang.String arg0, int arg1);
		void updateInt(int arg0, int arg1);
		void updateLong(java.lang.String arg0, long arg1);
		void updateLong(int arg0, long arg1);
		void updateShort(int arg0, short arg1);
		void updateShort(java.lang.String arg0, short arg1);
		void updateString(int arg0, java.lang.String arg1);
		void updateString(java.lang.String arg0, java.lang.String arg1);
		bool wasNull();
		global::java.math.BigDecimal getBigDecimal(int arg0, int arg1);
		global::java.math.BigDecimal getBigDecimal(int arg0);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0, int arg1);
		global::java.io.InputStream getAsciiStream(java.lang.String arg0);
		global::java.io.InputStream getAsciiStream(int arg0);
		global::java.io.InputStream getUnicodeStream(java.lang.String arg0);
		global::java.io.InputStream getUnicodeStream(int arg0);
		global::java.io.InputStream getBinaryStream(int arg0);
		global::java.io.InputStream getBinaryStream(java.lang.String arg0);
		global::java.sql.SQLWarning getWarnings();
		void clearWarnings();
		global::java.lang.String getCursorName();
		global::java.sql.ResultSetMetaData getMetaData();
		int findColumn(java.lang.String arg0);
		global::java.io.Reader getCharacterStream(java.lang.String arg0);
		global::java.io.Reader getCharacterStream(int arg0);
		void beforeFirst();
		void afterLast();
		int getRow();
		bool absolute(int arg0);
		bool relative(int arg0);
		void setFetchDirection(int arg0);
		int getFetchDirection();
		void setFetchSize(int arg0);
		int getFetchSize();
		int getConcurrency();
		bool rowUpdated();
		bool rowInserted();
		bool rowDeleted();
		void updateNull(java.lang.String arg0);
		void updateNull(int arg0);
		void updateBoolean(int arg0, bool arg1);
		void updateBoolean(java.lang.String arg0, bool arg1);
		void updateByte(int arg0, byte arg1);
		void updateByte(java.lang.String arg0, byte arg1);
		void updateBigDecimal(int arg0, java.math.BigDecimal arg1);
		void updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1);
		void updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1);
		void updateTimestamp(int arg0, java.sql.Timestamp arg1);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2);
		void updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void updateAsciiStream(int arg0, java.io.InputStream arg1);
		void updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void updateBinaryStream(int arg0, java.io.InputStream arg1);
		void updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateCharacterStream(int arg0, java.io.Reader arg1);
		void updateCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void updateObject(java.lang.String arg0, java.lang.Object arg1);
		void updateObject(int arg0, java.lang.Object arg1);
		void updateObject(int arg0, java.lang.Object arg1, int arg2);
		void updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2);
		void insertRow();
		void updateRow();
		void refreshRow();
		void cancelRowUpdates();
		void moveToInsertRow();
		void moveToCurrentRow();
		global::java.sql.Statement getStatement();
		global::java.sql.Clob getClob(java.lang.String arg0);
		global::java.sql.Clob getClob(int arg0);
		void updateRef(java.lang.String arg0, java.sql.Ref arg1);
		void updateRef(int arg0, java.sql.Ref arg1);
		void updateClob(java.lang.String arg0, java.sql.Clob arg1);
		void updateClob(int arg0, java.io.Reader arg1);
		void updateClob(java.lang.String arg0, java.io.Reader arg1);
		void updateClob(int arg0, java.io.Reader arg1, long arg2);
		void updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateClob(int arg0, java.sql.Clob arg1);
		void updateArray(int arg0, java.sql.Array arg1);
		void updateArray(java.lang.String arg0, java.sql.Array arg1);
		int getHoldability();
		void updateNString(java.lang.String arg0, java.lang.String arg1);
		void updateNString(int arg0, java.lang.String arg1);
		void updateNClob(int arg0, java.io.Reader arg1);
		void updateNClob(int arg0, java.io.Reader arg1, long arg2);
		void updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateNClob(java.lang.String arg0, java.io.Reader arg1);
		global::java.lang.String getNString(java.lang.String arg0);
		global::java.lang.String getNString(int arg0);
		global::java.io.Reader getNCharacterStream(int arg0);
		global::java.io.Reader getNCharacterStream(java.lang.String arg0);
		void updateNCharacterStream(int arg0, java.io.Reader arg1);
		void updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.ResultSet))]
	internal sealed partial class ResultSet_ : java.lang.Object, ResultSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResultSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject24758;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject24758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject24759;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject24759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject24760;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject24760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject24761;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getObject24761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean24762;
		bool java.sql.ResultSet.getBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._getBoolean24762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean24763;
		bool java.sql.ResultSet.getBoolean(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._getBoolean24763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte24764;
		byte java.sql.ResultSet.getByte(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallByteMethod(this.JvmHandle, global::java.sql.ResultSet_._getByte24764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte24765;
		byte java.sql.ResultSet.getByte(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallByteMethod(this.JvmHandle, global::java.sql.ResultSet_._getByte24765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort24766;
		short java.sql.ResultSet.getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallShortMethod(this.JvmHandle, global::java.sql.ResultSet_._getShort24766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort24767;
		short java.sql.ResultSet.getShort(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallShortMethod(this.JvmHandle, global::java.sql.ResultSet_._getShort24767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt24768;
		int java.sql.ResultSet.getInt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getInt24768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt24769;
		int java.sql.ResultSet.getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getInt24769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong24770;
		long java.sql.ResultSet.getLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.sql.ResultSet_._getLong24770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong24771;
		long java.sql.ResultSet.getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.sql.ResultSet_._getLong24771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat24772;
		float java.sql.ResultSet.getFloat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.ResultSet_._getFloat24772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat24773;
		float java.sql.ResultSet.getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.ResultSet_._getFloat24773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble24774;
		double java.sql.ResultSet.getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.ResultSet_._getDouble24774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble24775;
		double java.sql.ResultSet.getDouble(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.ResultSet_._getDouble24775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24776;
		byte[] java.sql.ResultSet.getBytes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBytes24776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24777;
		byte[] java.sql.ResultSet.getBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBytes24777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getArray24778;
		global::java.sql.Array java.sql.ResultSet.getArray(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getArray24778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getArray24779;
		global::java.sql.Array java.sql.ResultSet.getArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getArray24779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _next24780;
		bool java.sql.ResultSet.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._next24780);
		}
		internal static global::MonoJavaBridge.MethodId _getURL24781;
		global::java.net.URL java.sql.ResultSet.getURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getURL24781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getURL24782;
		global::java.net.URL java.sql.ResultSet.getURL(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getURL24782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _close24783;
		void java.sql.ResultSet.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._close24783);
		}
		internal static global::MonoJavaBridge.MethodId _getType24784;
		int java.sql.ResultSet.getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getType24784);
		}
		internal static global::MonoJavaBridge.MethodId _previous24785;
		bool java.sql.ResultSet.previous()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._previous24785);
		}
		internal static global::MonoJavaBridge.MethodId _getRef24786;
		global::java.sql.Ref java.sql.ResultSet.getRef(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getRef24786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getRef24787;
		global::java.sql.Ref java.sql.ResultSet.getRef(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getRef24787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getString24788;
		global::java.lang.String java.sql.ResultSet.getString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getString24788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString24789;
		global::java.lang.String java.sql.ResultSet.getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getString24789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst24790;
		bool java.sql.ResultSet.isFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isFirst24790);
		}
		internal static global::MonoJavaBridge.MethodId _getTime24791;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime24791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24792;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime24792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24793;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime24793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24794;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTime24794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24795;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate24795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24796;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate24796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24797;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate24797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24798;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getDate24798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed24799;
		bool java.sql.ResultSet.isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isClosed24799);
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24800;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp24800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24801;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp24801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24802;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp24802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24803;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getTimestamp24803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _last24804;
		bool java.sql.ResultSet.last()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._last24804);
		}
		internal static global::MonoJavaBridge.MethodId _first24805;
		bool java.sql.ResultSet.first()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._first24805);
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes24806;
		void java.sql.ResultSet.updateBytes(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBytes24806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes24807;
		void java.sql.ResultSet.updateBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBytes24807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLast24808;
		bool java.sql.ResultSet.isLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isLast24808);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst24809;
		bool java.sql.ResultSet.isBeforeFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isBeforeFirst24809);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast24810;
		bool java.sql.ResultSet.isAfterLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._isAfterLast24810);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob24811;
		global::java.sql.Blob java.sql.ResultSet.getBlob(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBlob24811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob24812;
		global::java.sql.Blob java.sql.ResultSet.getBlob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBlob24812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _updateDate24813;
		void java.sql.ResultSet.updateDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDate24813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate24814;
		void java.sql.ResultSet.updateDate(java.lang.String arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDate24814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime24815;
		void java.sql.ResultSet.updateTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTime24815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime24816;
		void java.sql.ResultSet.updateTime(java.lang.String arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTime24816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteRow24817;
		void java.sql.ResultSet.deleteRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._deleteRow24817);
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob24818;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob24818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob24819;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob24819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob24820;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob24820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob24821;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob24821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob24822;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob24822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob24823;
		void java.sql.ResultSet.updateBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBlob24823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble24824;
		void java.sql.ResultSet.updateDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDouble24824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble24825;
		void java.sql.ResultSet.updateDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateDouble24825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat24826;
		void java.sql.ResultSet.updateFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateFloat24826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat24827;
		void java.sql.ResultSet.updateFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateFloat24827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt24828;
		void java.sql.ResultSet.updateInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateInt24828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt24829;
		void java.sql.ResultSet.updateInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateInt24829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong24830;
		void java.sql.ResultSet.updateLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateLong24830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong24831;
		void java.sql.ResultSet.updateLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateLong24831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort24832;
		void java.sql.ResultSet.updateShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateShort24832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort24833;
		void java.sql.ResultSet.updateShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateShort24833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString24834;
		void java.sql.ResultSet.updateString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateString24834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString24835;
		void java.sql.ResultSet.updateString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateString24835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wasNull24836;
		bool java.sql.ResultSet.wasNull()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._wasNull24836);
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24837;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal24837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24838;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal24838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24839;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal24839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24840;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBigDecimal24840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream24841;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getAsciiStream24841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream24842;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getAsciiStream24842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream24843;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getUnicodeStream24843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream24844;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getUnicodeStream24844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream24845;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBinaryStream24845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream24846;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getBinaryStream24846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings24847;
		global::java.sql.SQLWarning java.sql.ResultSet.getWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getWarnings24847)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings24848;
		void java.sql.ResultSet.clearWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._clearWarnings24848);
		}
		internal static global::MonoJavaBridge.MethodId _getCursorName24849;
		global::java.lang.String java.sql.ResultSet.getCursorName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getCursorName24849)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData24850;
		global::java.sql.ResultSetMetaData java.sql.ResultSet.getMetaData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getMetaData24850)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _findColumn24851;
		int java.sql.ResultSet.findColumn(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._findColumn24851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24852;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getCharacterStream24852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24853;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getCharacterStream24853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _beforeFirst24854;
		void java.sql.ResultSet.beforeFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._beforeFirst24854);
		}
		internal static global::MonoJavaBridge.MethodId _afterLast24855;
		void java.sql.ResultSet.afterLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._afterLast24855);
		}
		internal static global::MonoJavaBridge.MethodId _getRow24856;
		int java.sql.ResultSet.getRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getRow24856);
		}
		internal static global::MonoJavaBridge.MethodId _absolute24857;
		bool java.sql.ResultSet.absolute(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._absolute24857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _relative24858;
		bool java.sql.ResultSet.relative(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._relative24858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection24859;
		void java.sql.ResultSet.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._setFetchDirection24859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection24860;
		int java.sql.ResultSet.getFetchDirection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getFetchDirection24860);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize24861;
		void java.sql.ResultSet.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._setFetchSize24861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize24862;
		int java.sql.ResultSet.getFetchSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getFetchSize24862);
		}
		internal static global::MonoJavaBridge.MethodId _getConcurrency24863;
		int java.sql.ResultSet.getConcurrency()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getConcurrency24863);
		}
		internal static global::MonoJavaBridge.MethodId _rowUpdated24864;
		bool java.sql.ResultSet.rowUpdated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._rowUpdated24864);
		}
		internal static global::MonoJavaBridge.MethodId _rowInserted24865;
		bool java.sql.ResultSet.rowInserted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._rowInserted24865);
		}
		internal static global::MonoJavaBridge.MethodId _rowDeleted24866;
		bool java.sql.ResultSet.rowDeleted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.ResultSet_._rowDeleted24866);
		}
		internal static global::MonoJavaBridge.MethodId _updateNull24867;
		void java.sql.ResultSet.updateNull(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNull24867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateNull24868;
		void java.sql.ResultSet.updateNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNull24868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean24869;
		void java.sql.ResultSet.updateBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBoolean24869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean24870;
		void java.sql.ResultSet.updateBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBoolean24870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte24871;
		void java.sql.ResultSet.updateByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateByte24871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte24872;
		void java.sql.ResultSet.updateByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateByte24872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal24873;
		void java.sql.ResultSet.updateBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBigDecimal24873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal24874;
		void java.sql.ResultSet.updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBigDecimal24874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp24875;
		void java.sql.ResultSet.updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTimestamp24875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp24876;
		void java.sql.ResultSet.updateTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateTimestamp24876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream24877;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream24877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream24878;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream24878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream24879;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream24879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream24880;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream24880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream24881;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream24881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream24882;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateAsciiStream24882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream24883;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream24883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream24884;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream24884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream24885;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream24885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream24886;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream24886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream24887;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream24887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream24888;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateBinaryStream24888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream24889;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream24889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream24890;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream24890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream24891;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream24891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream24892;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream24892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream24893;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream24893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream24894;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateCharacterStream24894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject24895;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject24895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject24896;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject24896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject24897;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject24897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject24898;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateObject24898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insertRow24899;
		void java.sql.ResultSet.insertRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._insertRow24899);
		}
		internal static global::MonoJavaBridge.MethodId _updateRow24900;
		void java.sql.ResultSet.updateRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateRow24900);
		}
		internal static global::MonoJavaBridge.MethodId _refreshRow24901;
		void java.sql.ResultSet.refreshRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._refreshRow24901);
		}
		internal static global::MonoJavaBridge.MethodId _cancelRowUpdates24902;
		void java.sql.ResultSet.cancelRowUpdates()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._cancelRowUpdates24902);
		}
		internal static global::MonoJavaBridge.MethodId _moveToInsertRow24903;
		void java.sql.ResultSet.moveToInsertRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._moveToInsertRow24903);
		}
		internal static global::MonoJavaBridge.MethodId _moveToCurrentRow24904;
		void java.sql.ResultSet.moveToCurrentRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._moveToCurrentRow24904);
		}
		internal static global::MonoJavaBridge.MethodId _getStatement24905;
		global::java.sql.Statement java.sql.ResultSet.getStatement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getStatement24905)) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _getClob24906;
		global::java.sql.Clob java.sql.ResultSet.getClob(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getClob24906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getClob24907;
		global::java.sql.Clob java.sql.ResultSet.getClob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getClob24907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _updateRef24908;
		void java.sql.ResultSet.updateRef(java.lang.String arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateRef24908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateRef24909;
		void java.sql.ResultSet.updateRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateRef24909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24910;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob24910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24911;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob24911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24912;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob24912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24913;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob24913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24914;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob24914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24915;
		void java.sql.ResultSet.updateClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateClob24915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray24916;
		void java.sql.ResultSet.updateArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateArray24916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray24917;
		void java.sql.ResultSet.updateArray(java.lang.String arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateArray24917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHoldability24918;
		int java.sql.ResultSet.getHoldability()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.ResultSet_._getHoldability24918);
		}
		internal static global::MonoJavaBridge.MethodId _updateNString24919;
		void java.sql.ResultSet.updateNString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNString24919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNString24920;
		void java.sql.ResultSet.updateNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNString24920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24921;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob24921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24922;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob24922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24923;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob24923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24924;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNClob24924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNString24925;
		global::java.lang.String java.sql.ResultSet.getNString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNString24925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNString24926;
		global::java.lang.String java.sql.ResultSet.getNString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNString24926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24927;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNCharacterStream24927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24928;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.ResultSet_._getNCharacterStream24928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24929;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream24929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24930;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream24930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24931;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream24931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24932;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.ResultSet_._updateNCharacterStream24932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static ResultSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.ResultSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/ResultSet"));
			global::java.sql.ResultSet_._getObject24758 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getObject24759 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getObject24760 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(I)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getObject24761 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			global::java.sql.ResultSet_._getBoolean24762 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.sql.ResultSet_._getBoolean24763 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBoolean", "(I)Z");
			global::java.sql.ResultSet_._getByte24764 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::java.sql.ResultSet_._getByte24765 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getByte", "(I)B");
			global::java.sql.ResultSet_._getShort24766 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getShort", "(I)S");
			global::java.sql.ResultSet_._getShort24767 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::java.sql.ResultSet_._getInt24768 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::java.sql.ResultSet_._getInt24769 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getInt", "(I)I");
			global::java.sql.ResultSet_._getLong24770 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::java.sql.ResultSet_._getLong24771 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getLong", "(I)J");
			global::java.sql.ResultSet_._getFloat24772 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::java.sql.ResultSet_._getFloat24773 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFloat", "(I)F");
			global::java.sql.ResultSet_._getDouble24774 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDouble", "(I)D");
			global::java.sql.ResultSet_._getDouble24775 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::java.sql.ResultSet_._getBytes24776 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::java.sql.ResultSet_._getBytes24777 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBytes", "(I)[B");
			global::java.sql.ResultSet_._getArray24778 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;");
			global::java.sql.ResultSet_._getArray24779 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getArray", "(I)Ljava/sql/Array;");
			global::java.sql.ResultSet_._next24780 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "next", "()Z");
			global::java.sql.ResultSet_._getURL24781 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.sql.ResultSet_._getURL24782 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getURL", "(I)Ljava/net/URL;");
			global::java.sql.ResultSet_._close24783 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "close", "()V");
			global::java.sql.ResultSet_._getType24784 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getType", "()I");
			global::java.sql.ResultSet_._previous24785 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "previous", "()Z");
			global::java.sql.ResultSet_._getRef24786 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getRef", "(I)Ljava/sql/Ref;");
			global::java.sql.ResultSet_._getRef24787 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;");
			global::java.sql.ResultSet_._getString24788 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.ResultSet_._getString24789 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::java.sql.ResultSet_._isFirst24790 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isFirst", "()Z");
			global::java.sql.ResultSet_._getTime24791 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getTime24792 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getTime24793 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getTime24794 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTime", "(I)Ljava/sql/Time;");
			global::java.sql.ResultSet_._getDate24795 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::java.sql.ResultSet_._getDate24796 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.ResultSet_._getDate24797 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(I)Ljava/sql/Date;");
			global::java.sql.ResultSet_._getDate24798 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.ResultSet_._isClosed24799 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isClosed", "()Z");
			global::java.sql.ResultSet_._getTimestamp24800 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._getTimestamp24801 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._getTimestamp24802 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._getTimestamp24803 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;");
			global::java.sql.ResultSet_._last24804 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "last", "()Z");
			global::java.sql.ResultSet_._first24805 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "first", "()Z");
			global::java.sql.ResultSet_._updateBytes24806 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBytes", "(Ljava/lang/String;[B)V");
			global::java.sql.ResultSet_._updateBytes24807 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBytes", "(I[B)V");
			global::java.sql.ResultSet_._isLast24808 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isLast", "()Z");
			global::java.sql.ResultSet_._isBeforeFirst24809 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isBeforeFirst", "()Z");
			global::java.sql.ResultSet_._isAfterLast24810 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "isAfterLast", "()Z");
			global::java.sql.ResultSet_._getBlob24811 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;");
			global::java.sql.ResultSet_._getBlob24812 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBlob", "(I)Ljava/sql/Blob;");
			global::java.sql.ResultSet_._updateDate24813 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDate", "(ILjava/sql/Date;)V");
			global::java.sql.ResultSet_._updateDate24814 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::java.sql.ResultSet_._updateTime24815 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTime", "(ILjava/sql/Time;)V");
			global::java.sql.ResultSet_._updateTime24816 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::java.sql.ResultSet_._deleteRow24817 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "deleteRow", "()V");
			global::java.sql.ResultSet_._updateBlob24818 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::java.sql.ResultSet_._updateBlob24819 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBlob24820 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateBlob24821 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBlob24822 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateBlob24823 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBlob", "(ILjava/sql/Blob;)V");
			global::java.sql.ResultSet_._updateDouble24824 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDouble", "(ID)V");
			global::java.sql.ResultSet_._updateDouble24825 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateDouble", "(Ljava/lang/String;D)V");
			global::java.sql.ResultSet_._updateFloat24826 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateFloat", "(Ljava/lang/String;F)V");
			global::java.sql.ResultSet_._updateFloat24827 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateFloat", "(IF)V");
			global::java.sql.ResultSet_._updateInt24828 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateInt", "(Ljava/lang/String;I)V");
			global::java.sql.ResultSet_._updateInt24829 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateInt", "(II)V");
			global::java.sql.ResultSet_._updateLong24830 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateLong", "(Ljava/lang/String;J)V");
			global::java.sql.ResultSet_._updateLong24831 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateLong", "(IJ)V");
			global::java.sql.ResultSet_._updateShort24832 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateShort", "(IS)V");
			global::java.sql.ResultSet_._updateShort24833 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateShort", "(Ljava/lang/String;S)V");
			global::java.sql.ResultSet_._updateString24834 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateString", "(ILjava/lang/String;)V");
			global::java.sql.ResultSet_._updateString24835 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.ResultSet_._wasNull24836 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "wasNull", "()Z");
			global::java.sql.ResultSet_._getBigDecimal24837 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getBigDecimal24838 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getBigDecimal24839 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getBigDecimal24840 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;");
			global::java.sql.ResultSet_._getAsciiStream24841 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getAsciiStream24842 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getAsciiStream", "(I)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getUnicodeStream24843 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getUnicodeStream24844 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getUnicodeStream", "(I)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getBinaryStream24845 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBinaryStream", "(I)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getBinaryStream24846 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.sql.ResultSet_._getWarnings24847 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.ResultSet_._clearWarnings24848 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "clearWarnings", "()V");
			global::java.sql.ResultSet_._getCursorName24849 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getCursorName", "()Ljava/lang/String;");
			global::java.sql.ResultSet_._getMetaData24850 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::java.sql.ResultSet_._findColumn24851 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "findColumn", "(Ljava/lang/String;)I");
			global::java.sql.ResultSet_._getCharacterStream24852 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.ResultSet_._getCharacterStream24853 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.ResultSet_._beforeFirst24854 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "beforeFirst", "()V");
			global::java.sql.ResultSet_._afterLast24855 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "afterLast", "()V");
			global::java.sql.ResultSet_._getRow24856 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getRow", "()I");
			global::java.sql.ResultSet_._absolute24857 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "absolute", "(I)Z");
			global::java.sql.ResultSet_._relative24858 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "relative", "(I)Z");
			global::java.sql.ResultSet_._setFetchDirection24859 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.ResultSet_._getFetchDirection24860 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFetchDirection", "()I");
			global::java.sql.ResultSet_._setFetchSize24861 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.ResultSet_._getFetchSize24862 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getFetchSize", "()I");
			global::java.sql.ResultSet_._getConcurrency24863 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getConcurrency", "()I");
			global::java.sql.ResultSet_._rowUpdated24864 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "rowUpdated", "()Z");
			global::java.sql.ResultSet_._rowInserted24865 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "rowInserted", "()Z");
			global::java.sql.ResultSet_._rowDeleted24866 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "rowDeleted", "()Z");
			global::java.sql.ResultSet_._updateNull24867 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNull", "(Ljava/lang/String;)V");
			global::java.sql.ResultSet_._updateNull24868 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNull", "(I)V");
			global::java.sql.ResultSet_._updateBoolean24869 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBoolean", "(IZ)V");
			global::java.sql.ResultSet_._updateBoolean24870 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBoolean", "(Ljava/lang/String;Z)V");
			global::java.sql.ResultSet_._updateByte24871 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateByte", "(IB)V");
			global::java.sql.ResultSet_._updateByte24872 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateByte", "(Ljava/lang/String;B)V");
			global::java.sql.ResultSet_._updateBigDecimal24873 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::java.sql.ResultSet_._updateBigDecimal24874 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::java.sql.ResultSet_._updateTimestamp24875 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::java.sql.ResultSet_._updateTimestamp24876 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateTimestamp", "(ILjava/sql/Timestamp;)V");
			global::java.sql.ResultSet_._updateAsciiStream24877 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateAsciiStream24878 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateAsciiStream24879 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateAsciiStream24880 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateAsciiStream24881 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateAsciiStream24882 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateBinaryStream24883 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateBinaryStream24884 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.ResultSet_._updateBinaryStream24885 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBinaryStream24886 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.ResultSet_._updateBinaryStream24887 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateBinaryStream24888 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.ResultSet_._updateCharacterStream24889 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::java.sql.ResultSet_._updateCharacterStream24890 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;I)V");
			global::java.sql.ResultSet_._updateCharacterStream24891 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateCharacterStream24892 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateCharacterStream24893 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateCharacterStream24894 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.ResultSet_._updateObject24895 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.sql.ResultSet_._updateObject24896 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(ILjava/lang/Object;)V");
			global::java.sql.ResultSet_._updateObject24897 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(ILjava/lang/Object;I)V");
			global::java.sql.ResultSet_._updateObject24898 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::java.sql.ResultSet_._insertRow24899 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "insertRow", "()V");
			global::java.sql.ResultSet_._updateRow24900 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateRow", "()V");
			global::java.sql.ResultSet_._refreshRow24901 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "refreshRow", "()V");
			global::java.sql.ResultSet_._cancelRowUpdates24902 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "cancelRowUpdates", "()V");
			global::java.sql.ResultSet_._moveToInsertRow24903 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "moveToInsertRow", "()V");
			global::java.sql.ResultSet_._moveToCurrentRow24904 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "moveToCurrentRow", "()V");
			global::java.sql.ResultSet_._getStatement24905 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getStatement", "()Ljava/sql/Statement;");
			global::java.sql.ResultSet_._getClob24906 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;");
			global::java.sql.ResultSet_._getClob24907 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getClob", "(I)Ljava/sql/Clob;");
			global::java.sql.ResultSet_._updateRef24908 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V");
			global::java.sql.ResultSet_._updateRef24909 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateRef", "(ILjava/sql/Ref;)V");
			global::java.sql.ResultSet_._updateClob24910 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::java.sql.ResultSet_._updateClob24911 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateClob24912 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.ResultSet_._updateClob24913 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateClob24914 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateClob24915 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateClob", "(ILjava/sql/Clob;)V");
			global::java.sql.ResultSet_._updateArray24916 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateArray", "(ILjava/sql/Array;)V");
			global::java.sql.ResultSet_._updateArray24917 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V");
			global::java.sql.ResultSet_._getHoldability24918 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getHoldability", "()I");
			global::java.sql.ResultSet_._updateNString24919 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.ResultSet_._updateNString24920 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNString", "(ILjava/lang/String;)V");
			global::java.sql.ResultSet_._updateNClob24921 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateNClob24922 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNClob24923 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNClob24924 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.ResultSet_._getNString24925 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.ResultSet_._getNString24926 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNString", "(I)Ljava/lang/String;");
			global::java.sql.ResultSet_._getNCharacterStream24927 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.ResultSet_._getNCharacterStream24928 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.ResultSet_._updateNCharacterStream24929 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.ResultSet_._updateNCharacterStream24930 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNCharacterStream24931 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.ResultSet_._updateNCharacterStream24932 = @__env.GetMethodIDNoThrow(global::java.sql.ResultSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
